using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{

public class DoctorManager
       {
        private readonly string _connectionString;

        public DoctorManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Create()
        {
            Console.WriteLine("Enter Doctor Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Doctor Specialization:");
            string specialization = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Doctor (Name, Specialization) VALUES (@Name, @Specialization)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Specialization", specialization);

                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Doctor created successfully.");
            }
        }

        public void Read()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Doctor";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}, Specialization: {reader["Specialization"]}");
                }
            }
        }

        public void Update()
        {
            Console.WriteLine("Enter Doctor ID to update:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new Doctor Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter new Doctor Specialization:");
            string specialization = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Doctor SET Name = @Name, Specialization = @Specialization WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Specialization", specialization);

                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Doctor updated successfully.");
            }
        }

        public void Delete()
        {
            Console.WriteLine("Enter Doctor ID to delete:");
            int id = int.Parse(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Doctor WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Doctor deleted successfully.");
            }
        }
    }
}

