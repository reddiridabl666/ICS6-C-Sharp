using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Shop;

namespace Shop
{
    public class Customer(string name, string address, decimal discount)
    {
        public string name = name;
        public string address = address;
        public decimal discount = discount;
    }

    public class Product(string name, decimal price)
    {
        public string name = name;
        public decimal price = price;
    }

    public class OrderLine(Product product, int num)
    {
        public Product product = product;
        public int num = num;
    }

    public class Order(int id, Customer customer, decimal price, List<OrderLine> lines)
    {
        public int id = id;
        public Customer customer = customer;
        public decimal discount = customer.discount;
        public decimal price = price;
        public List<OrderLine> lines = lines;
    }

    public class Database(Dictionary<string, Product> products)
    {
        public Dictionary<string, Product> products = products;

        static public Database Deserialize(string data)
        {
            var result = JsonConvert.DeserializeObject<Dictionary<string, Product>>(data) ?? throw new JsonException();
            return new Database(result);
        }
    }
}

class Program
{
    static int Main()
    {
        Console.WriteLine("Reading products");
        var fileData = File.ReadAllText("products.json");

        var db = Database.Deserialize(fileData);

        Console.WriteLine("Input customer name, address and discount");
        var customerParts = Console.ReadLine()?.Split();
        if (customerParts == null)
        {
            return -1;
        }

        Customer customer = new(customerParts[0], customerParts[1], decimal.Parse(customerParts[2]));

        List<OrderLine> orderLines = [];
        foreach (var pair in db.products)
        {
            int num = Random.Shared.Next() % 9 + 1;
            orderLines.Add(new OrderLine(pair.Value, num));
        }

        var price = orderLines.Aggregate((decimal)0, (sum, line) => sum + line.num * db.products[line.product.name].price * customer.discount);

        var order = new Order(Random.Shared.Next(), customer, price, orderLines);

        using var resultFile = File.Open("order.json", FileMode.Create);
        resultFile.Write(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(order)));
        return 0;
    }
}
