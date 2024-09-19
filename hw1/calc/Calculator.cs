using Handler = System.Action;
using Operation = System.Func<int, int, int>;

namespace Calc
{
    class Functors
    {
        static public Operation Plus = (a, b) => a + b;
        static public Operation Minus = (a, b) => a - b;
        static public Operation Multiply = (a, b) => a * b;
        static public Operation Divide = (a, b) => a / b;
    }

    public class Calculator
    {
        List<string> tokens = [];

        Stack<string> stack = new();

        readonly Dictionary<string, Dictionary<string, Handler>> handlers;

        static readonly Dictionary<string, Operation> operationsMap = new()
        {
            ["+"] = Functors.Plus,
            ["-"] = Functors.Minus,
            ["*"] = Functors.Multiply,
            ["/"] = Functors.Divide,
        };

        static readonly HashSet<char> validOperations = ['+', '-', '*', '/', '(', ')'];

        public Calculator()
        {
            handlers = new()
            {
                ["start"] = new()
                {
                    ["+"] = Store,
                    ["-"] = Store,
                    ["*"] = Store,
                    ["/"] = Store,
                    ["("] = Store,
                    [")"] = Error,
                    ["end"] = Nop,
                },
                ["+"] = new()
                {
                    ["+"] = Fold,
                    ["-"] = Fold,
                    ["*"] = Store,
                    ["/"] = Store,
                    ["("] = Store,
                    [")"] = Fold,
                    ["end"] = Fold,
                },
                ["-"] = new()
                {
                    ["+"] = Fold,
                    ["-"] = Fold,
                    ["*"] = Store,
                    ["/"] = Store,
                    ["("] = Store,
                    [")"] = Fold,
                    ["end"] = Fold,
                },
                ["*"] = new()
                {
                    ["+"] = Fold,
                    ["-"] = Fold,
                    ["*"] = Fold,
                    ["/"] = Fold,
                    ["("] = Store,
                    [")"] = Fold,
                    ["end"] = Fold,
                },
                ["/"] = new()
                {
                    ["+"] = Fold,
                    ["-"] = Fold,
                    ["*"] = Fold,
                    ["/"] = Fold,
                    ["("] = Store,
                    [")"] = Fold,
                    ["end"] = Fold,
                },
                ["("] = new()
                {
                    ["+"] = Store,
                    ["-"] = Store,
                    ["*"] = Store,
                    ["/"] = Store,
                    ["("] = Store,
                    [")"] = Fold,
                    ["end"] = Error,
                },
                [")"] = new()
                {
                    ["+"] = Fold,
                    ["-"] = Fold,
                    ["*"] = Fold,
                    ["/"] = Fold,
                    ["("] = Error,
                    [")"] = Fold,
                    ["end"] = Fold,
                }
            };
        }

        public int Calculate(string expression)
        {
            stack = new(["start"]);

            tokens = Tokenize(expression);

            while (stack.Count > 1 || tokens.Count > 2)
            {
                // Console.Write("Stack: ");
                // stack.ToList().ForEach(x => Console.Write(x + " "));
                // Console.WriteLine();

                // Console.Write("Tokens: ");
                // tokens.ForEach(x => Console.Write(x + " "));
                // Console.WriteLine();
                // Console.WriteLine();

                if (validOperations.Contains(tokens[0][0]) && tokens[0] != "(")
                {
                    throw new Exception("operator " + stack.Peek() + " must be followed by a number");
                }


                var op = tokens.Count() > 1 ? tokens[1] : tokens[0];
                if (op == "(")
                {
                    throw new Exception("expected operator other than '('");
                }

                if (validOperations.Contains(tokens[0][0]))
                {
                    op = tokens[0];
                }

                if (!handlers[stack.Peek()].TryGetValue(op, out var handler))
                {
                    throw new Exception(string.Format("unknown operation: '{0}'", op));
                }

                handler();
            }

            return int.Parse(tokens[0]);
        }

        private void Store()
        {
            string token;
            do
            {
                token = tokens[0];
                stack.Push(token);
                tokens.RemoveAt(0);
            } while (!validOperations.Contains(token[0]));
        }

        private void Error()
        {
            throw new Exception("parenthesis mismatch");
        }

        private void Nop()
        {
            return;
        }

        private void Fold()
        {
            if (int.TryParse(tokens[0], out int secondOperand))
            {
                var opName = stack.Pop();
                if (opName == "(")
                {
                    tokens.RemoveAt(1);
                    return;
                }

                var firstOperand = int.Parse(stack.Pop());

                if (operationsMap.TryGetValue(opName, out Operation? op))
                {
                    var result = op(firstOperand, secondOperand);
                    tokens[0] = result.ToString();
                }
                else
                {
                    throw new Exception(string.Format("unknown operation: '{0}'", opName));
                }
            }
        }

        private static List<string> Tokenize(string expression)
        {
            expression = expression.Replace(" ", "");
            List<string> result = [];
            string currentNumber = "";

            foreach (char c in expression)
            {
                if (validOperations.Contains(c))
                {
                    if (currentNumber.Length > 0)
                    {
                        result.Add(currentNumber);
                        currentNumber = "";
                    }
                    result.Add("" + c);
                }
                else if (c - '0' >= 0 && c - '0' <= 9)
                {
                    currentNumber += c;
                }
                else
                {
                    throw new Exception(string.Format("unsupported character: '{0}'", c));
                }
            }

            if (currentNumber.Length > 0)
            {
                result.Add(currentNumber);
            }

            result.Add("end");

            return result;
        }
    }

    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("should pass exactly 1 argument");
                return -1;
            }

            Console.WriteLine(new Calculator().Calculate(args[0]));
            return 0;
        }
    }
}
