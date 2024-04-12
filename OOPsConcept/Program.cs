namespace OOPsConcept
{
    public class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Bike();
            Bike bike = new Bike();
            Car car = new Car();
           
            v.Start();
            car.Start();
            bike.Start();


            Console.WriteLine("oberved");
            v.Stop();          
            bike.Stop();
            car.Stop();

            Console.WriteLine("oberved");

            v.Acceleration();
            car.Acceleration();
            bike.Acceleration();

            Console.WriteLine("oberved");
            bike.UseKickStand();
            car.OpenSunRoof();
            
        }
    }
}
