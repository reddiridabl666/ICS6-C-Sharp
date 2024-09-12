class Reflection
{
    public string strField = "";
    public int intField;

    [CustomAttribute]
    public int intFieldWithAttribute;

    public int Method(string str)
    {
        return strField.Length + str.Length;
    }

    [CustomAttribute]
    public int MethodWithAttribute(string str)
    {
        return Method(str);
    }
}

class CustomAttribute : Attribute { }

class Program
{
    static int Main()
    {

        return 0;
    }
}
