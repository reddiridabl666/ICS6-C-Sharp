class Reflection
{
    public string strField = "";
    public int intField;

    [Custom]
    public int intFieldWithAttribute = 0;

    public Reflection()
    {
        strField = "field";
        intField = 42;
    }

    public void Method(string str)
    {
        Console.WriteLine("Method was called with arg '{0}'", str);
    }
}

class CustomAttribute : Attribute { }

class Program
{
    static int Main()
    {
        var type = typeof(Reflection);
        Console.WriteLine("Constructors:");

        foreach (var elem in type.GetConstructors())
        {
            Console.WriteLine(elem);
        }

        Console.WriteLine("\nMethods:");

        foreach (var elem in type.GetMethods())
        {
            Console.WriteLine(elem);
        }

        Console.WriteLine("\nFields:");

        foreach (var elem in type.GetFields())
        {
            Console.WriteLine(elem);
        }

        Console.WriteLine("\nMembers with custom attribute:");

        foreach (var elem in type.GetFields())
        {
            if (Attribute.IsDefined(elem, typeof(CustomAttribute)))
            {
                Console.WriteLine(elem);
            }
        }
        Console.WriteLine();

        type.GetMethod("Method")?.Invoke(new Reflection(), ["Hello"]);
        return 0;
    }
}
