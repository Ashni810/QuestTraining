using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Managment
{
    public class PatientManager
    {
        private readonly string _connectionString;

        public PatientManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Create()
        {
            Console.WriteLine("Enter Patient Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Patient Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Patient Gender (Male/Female/Other):");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter Medical Condition:");
            string medicalCondition = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "INSERT INTO Patient (Name, Age, Gender, MedicalCondition) VALUES (@Name, @Age, @Gender, @MedicalCondition)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@MedicalCondition", medicalCondition);

                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Patient created successfully.");
            }
        }

        public void Read()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "SELECT * FROM Patient";
                var command = new SqlCommand(query, connection);

                connection.Open();
                var reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Console.WriteLine($"ID: {reader["Id"]}, Name: {reader["Name"]}, Age: {reader["Age"]}, Gender: {reader["Gender"]}, Medical Condition: {reader["MedicalCondition"]}");
                }

            }
        }

        public void Update()
        {
            Console.WriteLine("Enter Patient ID to update:");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new Patient Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter new Patient Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new Patient Gender (Male/Female/Other):");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter new Medical Condition:");
            string medicalCondition = Console.ReadLine();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "UPDATE Patient SET Name = @Name, Age = @Age, Gender = @Gender, MedicalCondition = @MedicalCondition WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Age", age);
                command.Parameters.AddWithValue("@Gender", gender);
                command.Parameters.AddWithValue("@MedicalCondition", medicalCondition);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Patient updated successfully.");
                }
                else
                {
                    Console.WriteLine("Patient not found.");
                }
            }
        }

        public void Delete()
        {
            Console.WriteLine("Enter Patient ID to delete:");
            int id = int.Parse(Console.ReadLine());

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = "DELETE FROM Patient WHERE Id = @Id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Id", id);

                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    Console.WriteLine("Patient deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Patient not found.");
                }
            }
        }
    }
}



