class Matrix
{
    static public int FindMax(int[,] matrix)
    {
        int max = int.MinValue;

        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                if (max < matrix[i, j])
                {
                    max = matrix[i, j];
                }
            }
        }
        return max;
    }

    static public void Replace(ref int[,] matrix, int from, int to)
    {
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                if (matrix[i, j] == from)
                {
                    matrix[i, j] = to;
                }
            }
        }
    }

    static public int[,]? Read(uint n, uint m)
    {
        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; ++i)
        {
            var line = Console.ReadLine()?.Split().Select(int.Parse).ToArray();
            if (line == null || line.Length != m)
            {
                Console.WriteLine("invalid values entered, should enter {0} integers", m);
                return null;
            }

            for (int j = 0; j < m; ++j)
            {
                matrix[i, j] = line[j];
            }
        }

        return matrix;
    }

    static public void Write(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); ++i)
        {
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static int Main()
    {
        Console.WriteLine("Enter matrix dimensions");

        var args = Console.ReadLine()?.Split().Select(uint.Parse).ToArray();
        if (args == null || args.Length != 2)
        {
            Console.WriteLine("invalid values entered, should enter 2 unsigned integers");
            return -1;
        }

        Console.WriteLine("Enter matrix");
        var matrix = Matrix.Read(args[0], args[1]);
        if (matrix == null)
        {
            return -1;
        }

        int max = Matrix.FindMax(matrix);
        Matrix.Replace(ref matrix, max, 0);

        Console.WriteLine();
        Matrix.Write(matrix);

        return 0;
    }
}
