class Program
{
    static int Main()
    {
        Console.WriteLine("Enter two numbers");

        var input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("You should enter two numbers");
            return -1;
        }

        try
        {
            var numbers = input.Split(' ', 2).Select(decimal.Parse).ToArray();
            if (numbers.Length < 2)
            {
                Console.WriteLine("You should enter two numbers");
                return -1;
            }
            Console.WriteLine(numbers[0] / numbers[1]);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("You can't divide by zero");
            return -1;
        }
        catch (FormatException)
        {
            Console.WriteLine("You should enter two numbers");
            return -1;
        }
        catch (OverflowException)
        {
            Console.WriteLine("Numbers too large");
            return -1;
        }

        return 0;
    }
}
