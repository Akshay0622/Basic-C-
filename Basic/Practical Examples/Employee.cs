using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_Examples
{
    public class Employee
    {
        public int Id { get; set; }
        public string EmpName { get; set; }
        public string Department { get; set; }
        public double Salery { get; set; }

        public Employee(int id, string name, string department, double salery)
        {

            this.Id = id;
            this.EmpName = name;
            this.Department = department;
            this.Salery = salery;

        }

        public static void GetEmployeeDetail(string department, Employee[] emps)
        {
            foreach (var emp in emps)
            {
                if (emp.Department == department)
                {
                    Console.WriteLine(emp);
                }
            }


        }

        public override string ToString()
        {
            return $"Employee:{Id},{EmpName},{Salery},{Department}";
        }
    }
}
