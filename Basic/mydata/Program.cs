using System.Data.SqlClient;

namespace mydata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=mydata;Trusted_Connection=True;");

            sqlConnection.Open();

            Console.WriteLine("Connected to Database");

            SqlCommand cmd = new SqlCommand("insert into employee(eid,name,salary) values(3,'ganesh',300000)", sqlConnection);

            cmd.ExecuteNonQuery();

            Console.WriteLine("Record inserted");


        }
    }
}
