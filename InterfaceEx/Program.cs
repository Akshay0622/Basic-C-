namespace InterfaceEx
{
    public class Program
    {
        static void Main(string[] args)
        {

            Person person = new Person();
            person.Name = "John";
            person.Age = 30;

            // Call the method implemented from the interface
            person.DisplayInfo();

            // Interface reference
            IPerson personInterface = new Person();
            personInterface.Name = "Alice";
            personInterface.Age = 25;
            personInterface.DisplayInfo();
        }
    }
}
