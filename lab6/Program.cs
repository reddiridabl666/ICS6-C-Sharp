class Program
{
    static int[,] RandomMatrix(int n, int m)
    {
        var result = new int[n, m];

        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
                result[i, j] = Random.Shared.Next();
                Console.Write(result[i, j].ToString() + " ");
            }
            Console.WriteLine();
        }

        return result;
    }

    static List<int> RandomEven(int n, int m)
    {
        List<int> result = [];
        var matrix = RandomMatrix(n, m);

        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
                if (matrix[i, j] % 2 == 0)
                {
                    result.Add(matrix[i, j]);
                }
            }
        }
        return result;
    }

    static int Main()
    {
        Console.WriteLine("Input matrix dimensions");
        var dimensions = Console.ReadLine()?.Split(' ', 2).Select(int.Parse).ToArray();
        if (dimensions == null)
        {
            Console.WriteLine("Error reading");
            return -1;
        }
        Func<int, int, List<int>> func = RandomEven;

        Console.WriteLine("Random matrix:");
        var result = func(dimensions[0], dimensions[1]);

        Console.WriteLine("\nEven numbers:");
        result.ForEach(elem => Console.Write("{0} ", elem));
        Console.WriteLine();

        return 0;
    }
}
