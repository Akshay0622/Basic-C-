namespace OperatorEx
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Product p1 = new Product(1, "pen", 1000);   // p1(900) ===>[pid=1 name=pen price=1000] Product class object at addres 900

            Product p2 = new Product(1, "pen", 1000); // p2(800) ===>[pid=1 name=pen price=1000] Product class object at addres 800

            Console.WriteLine(p1 == p2); // == compare address . Overload it to content comparision

            Console.WriteLine(p1 != p2);



        }
    }
}
