namespace DataFetchingEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product[] products = new Product[]
              {
            new Product(1, "TV", 25000, "Electronic"),
            new Product(2, "Laptop", 55000, "Electronic"),
            new Product(3, "Watch", 5000, "Fashion"),
            new Product(4, "Shirt", 1500, "Fashion"),
            new Product(5, "Mobile", 30000, "Electronic")
              };

            Product.GetProducts("Electronic",products);

            Console.ReadLine();
        }
        
    }
}