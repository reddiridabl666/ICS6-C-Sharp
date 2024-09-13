class Program
{
    class Product(string name, string weight) : IComparable<Product>
    {
        public decimal weightKg = ParseWeight(weight);
        string weight = weight;
        string name = name;

        static decimal ParseWeight(string weight)
        {
            string weightValue = "";
            int i = 0;
            var ch = weight[i];

            if (ch == '-')
            {
                throw new ArgumentOutOfRangeException("value can not be negative");
            }

            while (ch >= '0' && ch <= '9' && i < weight.Length)
            {
                weightValue += ch;
                ++i;
                ch = weight[i];
            }

            if (weightValue.Length < 0)
            {
                throw new ArgumentOutOfRangeException("value should start with a number");
            }

            var weightNum = decimal.Parse(weightValue);
            if (i >= weight.Length)
            {
                return weightNum;
            }

            var dim = weight[i..];
            var multiplier = dim switch
            {
                "т" => 1000,
                "г" => 0.001,
                _ => 1,
            };
            return weightNum * (decimal)multiplier;
        }

        public int CompareTo(Product? other)
        {
            if (other == null)
            {
                return 1;
            }

            if (weightKg == other.weightKg)
            {
                return 0;
            }

            if (weightKg < other.weightKg)
            {
                return -1;
            }
            return 1;
        }

        override public string ToString()
        {
            return weight + " " + name;
        }
    }

    public static int Main()
    {
        var products = File.ReadAllLines("input.txt")
                        .Select(line => line.Split())
                        .Select(parts => new Product(parts[1], parts[0]))
                        .ToList();

        products.Sort();

        products.ForEach(Console.WriteLine);

        return 0;
    }
}
