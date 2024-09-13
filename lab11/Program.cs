class Program
{
    class Point(double x, double y)
    {
        readonly double x = x;
        readonly double y = y;

        public double X
        {
            get
            {
                return x;
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
        }

        public override string ToString()
        {
            return string.Format("{{{0:0.00}, {1:0.00}}}", X, y);
        }
    }

    static List<Point> RandomPoints()
    {
        List<Point> result = [];

        for (int i = 0; i < 5; ++i)
        {
            result.Add(new Point(
                Random.Shared.NextDouble(),
                Random.Shared.NextDouble()
            ));
        }

        return result;
    }

    class DistanceComparer : IComparer<Point>
    {
        public int Compare(Point? a, Point? b)
        {
            if (a == null && b == null)
            {
                return 0;
            }
            if (a == null)
            {
                return -1;
            }
            if (b == null)
            {
                return 1;
            }

            return Comparer<double>.Default.Compare(a.X * a.X + a.Y * a.Y, b.X * b.X + b.Y * b.Y);
        }
    }
    class XComparer : IComparer<Point>
    {
        public int Compare(Point? a, Point? b)
        {
            if (a == null && b == null)
            {
                return 0;
            }
            if (a == null)
            {
                return -1;
            }
            if (b == null)
            {
                return 1;
            }

            return Comparer<double>.Default.Compare(a.X, b.X);
        }
    }

    class YComparer : IComparer<Point>
    {
        public int Compare(Point? a, Point? b)
        {
            if (a == null && b == null)
            {
                return 0;
            }
            if (a == null)
            {
                return -1;
            }
            if (b == null)
            {
                return 1;
            }

            return Comparer<double>.Default.Compare(a.Y, b.Y);
        }
    }

    class DiagComparer : IComparer<Point>
    {
        public int Compare(Point? a, Point? b)
        {
            if (a == null && b == null)
            {
                return 0;
            }
            if (a == null)
            {
                return -1;
            }
            if (b == null)
            {
                return 1;
            }

            return Comparer<double>.Default.Compare(Math.Abs(b.Y - b.X), Math.Abs(a.Y - a.X));
        }
    }

    public static int Main()
    {
        var points = RandomPoints();

        Console.WriteLine("Distance comparer");
        points.Sort(new DistanceComparer());
        points.ForEach(Console.WriteLine);

        Console.WriteLine("\nX comparer");
        points.Sort(new XComparer());
        points.ForEach(Console.WriteLine);

        Console.WriteLine("\nY comparer");
        points.Sort(new YComparer());
        points.ForEach(Console.WriteLine);

        Console.WriteLine("\nDiag distance comparer");
        points.Sort(new DiagComparer());
        points.ForEach(Console.WriteLine);

        return 0;
    }
}
