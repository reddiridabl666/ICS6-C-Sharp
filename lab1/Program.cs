class Numbers
{
    static public bool IsPrime(uint number)
    {
        if (number < 2)
        {
            return false;
        }

        for (int i = 2; i * i <= number; ++i)
        {
            if (number % i == 0)
            {
                return false;
            }
        }
        return true;
    }
}

class Program
{
    static int Main()
    {
        Console.WriteLine("Input any number of natural numbers on one line");

        var args = Console.ReadLine()?.Split().Select(arg => uint.Parse(arg)).ToArray();
        if (args == null)
        {
            Console.WriteLine("error reading from console");
            return -1;
        }

        Console.WriteLine("Prime numbers:");

        int primeCount = 0;
        foreach (var elem in args)
        {
            if (Numbers.IsPrime(elem))
            {
                Console.Write("{0} ", elem);
                ++primeCount;
            }
        }

        Console.WriteLine("\n{0} prime numbers found", primeCount);
        return 0;
    }
}
