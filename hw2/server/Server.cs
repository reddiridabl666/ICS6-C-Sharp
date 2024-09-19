using System.Net;
using System.Net.Sockets;
using System.Text;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace Http
{
    public class Server(int port, string root)
    {
        private readonly TcpListener listener = new(IPAddress.Loopback, port);

        private readonly string root = root;

        private const string httpHeaders =
            "Content-Type: text/html; charset=UTF-8\r\n" +
            "Connection: close\r\n\r\n";

        static private Dictionary<int, string> codeMsg = new()
        {
            [404] = "Not Found",
            [405] = "Method Not Allowed",
            [200] = "OK",
            [500] = "Internal Server Error"
        };

        Calc.Calculator calculator = new();

        public void Run()
        {
            listener.Start();
            Console.WriteLine("Starting server at port {0}", port);

            while (true)
            {
                var client = listener.AcceptTcpClient();
                if (client == null)
                    continue;

                Thread thread = new(new ParameterizedThreadStart(HandleClient));
                thread.Start(client);
            }
        }

        ~Server()
        {
            while (listener.Pending())
            {
                Thread.Sleep(100);
            }
            listener.Stop();
        }

        private void HandleClient(object? obj)
        {
            if (obj is not TcpClient client)
            {
                return;
            }

            using NetworkStream stream = client.GetStream();

            stream.ReadTimeout = 5 * 1000;

            var httpRequestStartLine = ReadUntil(stream, "\r\n", out bool ok);
            if (!ok)
            {
                throw new Exception(string.Format("failed to read start line, got: '{0}'", httpRequestStartLine));
            }

            var parts = httpRequestStartLine.Split(' ');
            if (parts.Length < 3)
            {
                throw new Exception(string.Format("invalid request start line: '{0}'", httpRequestStartLine));
            }

            var method = parts[0];
            var endpoint = parts[1];

            Routing(stream, method, endpoint);
        }

        private void Routing(NetworkStream stream, string method, string endpoint)
        {
            Console.WriteLine("{0} {1}", method, endpoint);

            if (endpoint == "/")
            {
                endpoint = "/index.html";
            }

            if (endpoint == "/calculate" && method == "POST")
            {
                Calculate(stream);
                return;
            }

            if (method != "GET")
            {
                HandleError(stream, 405);
                return;
            }

            ServeFile(stream, endpoint);
        }

        private void ServeFile(NetworkStream stream, string filename)
        {
            var filePath = root + filename;

            if (!File.Exists(filePath))
            {
                HandleError(stream, 404);
                return;
            }

            var fileData = File.ReadAllBytes(filePath);
            WriteResponse(stream, 200, Encoding.UTF8.GetString(fileData));
        }

        private void HandleError(NetworkStream stream, int code)
        {
            if (!codeMsg.TryGetValue(code, out string? _))
            {
                code = 500;
            }

            var fileName = string.Format("/{0}.html", code);
            var fileData = File.ReadAllBytes(root + fileName);

            WriteResponse(stream, 500, Encoding.UTF8.GetString(fileData));
        }

        private void Calculate(NetworkStream stream)
        {
            var headers = ReadHeaders(stream);

            var body = Read(stream, int.Parse(headers["content-length"]));

            var request = JsonConvert.DeserializeObject<CalculateQuery>(body);

            try
            {
                var result = calculator.Calculate(request.query);
                var responseBody = JsonConvert.SerializeObject(new CalculateResult(result));
                WriteResponse(stream, 200, responseBody);
            }
            catch (Exception e)
            {
                var responseBody = JsonConvert.SerializeObject(new ErrorResponse(e.Message));
                WriteResponse(stream, 400, responseBody);
            }
        }

        private static string HttpResponseStartLine(int code)
        {
            var ok = codeMsg.TryGetValue(code, out string? msg);
            if (!ok)
            {
                code = 500;
                msg = codeMsg[code];
            }
            return string.Format("HTTP/1.1 {0} {1}\r\n", code, msg);
        }

        private static Dictionary<string, string> ReadHeaders(NetworkStream stream)
        {
            Dictionary<string, string> result = new();

            while (true)
            {
                var header = ReadUntil(stream, "\r\n", out bool ok);
                if (!ok)
                {
                    throw new Exception("failed to read header");
                }
                if (header == "\r\n")
                {
                    return result;
                }

                var parts = header.Split(": ", 2);

                if (parts.Length < 2)
                {
                    throw new Exception("invalid header format: missing semicolon");
                }

                result.Add(parts[0].ToLower(), parts[1].TrimEnd(['\n', '\r']));
            }
        }

        private static void WriteResponse(NetworkStream stream, int code, string body)
        {
            var response = HttpResponseStartLine(code) + httpHeaders + body;
            stream.Write(Encoding.UTF8.GetBytes(response));
        }

        private static string Read(NetworkStream stream, int limit)
        {
            byte[] data = new byte[limit];
            stream.ReadExactly(data, 0, limit);
            return Encoding.UTF8.GetString(data);
        }

        private static string ReadUntil(NetworkStream stream, string delimiter, out bool ok)
        {
            string result = "";

            while (!result.EndsWith(delimiter))
            {
                int readByte = stream.ReadByte();
                if (readByte == -1)
                {
                    ok = false;
                    return result;
                }
                // Console.Write((char)readByte);
                result += (char)readByte;
            }

            ok = true;
            return result;
        }
    }

    struct CalculateResult(int result)
    {
        public int result = result;
    }


    struct ErrorResponse(string result)
    {
        public string result = result;
    }

    struct CalculateQuery(string query)
    {
        public string query = query;
    }
}
