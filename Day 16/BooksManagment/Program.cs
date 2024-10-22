using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BooksManagment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var connStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ashni\OneDrive\Documents\QuestDb.mdf;Integrated Security=True";

            var createTableQuery = @"CREATE TABLE Books
                     (
                        Id INT PRIMARY KEY,
                        Title VARCHAR(255) NOT NULL,
                        Author VARCHAR(255) NOT NULL,
                        Year INT NOT NULL,
                        Genre VARCHAR(100) NOT NULL
                   )";
            var conn = new SqlConnection(connStr);
            conn.Open();
            var command = new SqlCommand(createTableQuery, conn);
            command.ExecuteNonQuery();
            conn.Close();

        }    
    }
}
