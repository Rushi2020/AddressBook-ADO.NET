using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_ADO.NET
{
    internal class AddressBookRepo
    {
        public static string connectionString = @"Data Source=(Localdb)\MSSQLLocalDB;Initial Catalog=AddressBook_Service;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public void DataBaseConnection()
        {
            try
            {
                this.connection.Open();
                Console.WriteLine("connection established");
                this.connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
