using System.Text;

class Shop
{
    private List<Order> orders = [];

    struct Order(int id, int sum)
    {
        public int id = id;
        public int sum = sum;
    }

    public void Load(string path)
    {
        var lines = File.ReadAllLines(path);
        foreach (var line in lines)
        {
            var parts = line.Split(' ', 2);
            orders.Add(new Order(
                int.Parse(parts[0]),
                int.Parse(parts[1])
            ));
        }
    }

    public void Save(int minSum, string path)
    {
        using var file = File.OpenWrite(path);

        orders
            .Where(order => order.sum > minSum)
            .ToList().ForEach(order =>
            {
                var data = string.Format("{0} {1}\n", order.id, order.sum);
                file.Write(Encoding.UTF8.GetBytes(data));
            });
    }
}

class Program
{
    static string path = "orders.txt";
    static string savePath = "orders_filtered.txt";

    static int Main()
    {
        Shop shop = new();
        shop.Load(path);

        Console.WriteLine("Input minimum sum");
        var line = Console.ReadLine();
        if (line == null)
        {
            Console.WriteLine("Error reading from console");
            return -1;
        }

        var minSum = int.Parse(line);
        shop.Save(minSum, savePath);

        return 0;
    }
}
