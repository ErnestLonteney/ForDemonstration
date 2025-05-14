using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.Common;
using System.Text;

namespace ADO.NET.Example
{
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;

            string connectionString = "Server=localhost;Database=ShopDb;Trusted_Connection=True;TrustServerCertificate=true";

            using SqlConnection connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
            }
            catch (Exception)
            {
            }

            string commandText = @"SELECT * FROM Customers";

            SqlCommand command = new SqlCommand(commandText, connection);
            
            //using var reader = command.ExecuteReader();

            //if (reader is not null)
            //{
            //    while (reader.Read())
            //    {
            //        Console.WriteLine(reader["FirstName"]);
            //        Console.WriteLine(reader["LastName"]);
            //    }
            //}


            DataTable customers = new DataTable("Customers");

            SqlDataAdapter customerAdapter = new(command);
            customerAdapter.InsertCommand = new SqlCommand("INSERT INTO CUSTOMERS");

            customerAdapter.Fill(customers);


            foreach (DataRow row in customers.Rows)
            {
                Console.Write(row["FirstName"]);
                Console.Write(" ");
                Console.WriteLine(row["LastName"]);
            }

           var firstRow = customers.Rows[0];

            firstRow.BeginEdit();
            firstRow["Phone"] = "+380987776655";
            firstRow.EndEdit();

            customers.AcceptChanges();


            customerAdapter.Update(customers);
        }
    }
}
