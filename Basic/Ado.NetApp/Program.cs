using System.Data.SqlClient;
namespace Ado.NetApp
{
    public class Program
{
    static void Main(string[] args)
    {
        SqlConnection sqlConnection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=mydata;Trusted_Connection=True;");

        sqlConnection.Open();

        Console.WriteLine("Connected to Database");

         SqlCommand cmd = new SqlCommand("insert into employee(eid,name,salary) values(4,'akshay',400000)",sqlConnection);

        // SqlCommand cmd = new SqlCommand("update employee set name='navin' , salary=500000 where eid=4", sqlConnection);

        //SqlCommand cmd = new SqlCommand("delete from employee where eid=4", sqlConnection);


        cmd.ExecuteNonQuery();// it execute non-select queries like insert/update/delete etc

        Console.WriteLine("Done");


    }
}
}
