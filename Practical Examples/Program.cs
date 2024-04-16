namespace Practical_Examples
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee[] employee = new Employee[]
         {
                new Employee (1,"Akshay","Software Developer",25000),
                new Employee (2,"Shree","Software Developer",45000),
                new Employee (3,"Rushi","Software Testing",30000),
                new Employee (4,"krutika","Software Developer",35000)
         };

            Employee.GetEmployeeDetail("Software Developer", employee);

        }
    }
}
