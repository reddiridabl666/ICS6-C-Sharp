class Program
{
    static int Main()
    {
        Http.Server server = new(49123, "static");
        server.Run();
        return 0;
    }
}
