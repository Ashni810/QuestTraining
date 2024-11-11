using System;
using System.Globalization;
using System.IO;
using CsvHelper;
using System.Collections.Generic;

namespace ConsoleApp9
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            string filePath = "C:\\Users\\ashni\\OneDrive\\Documents\\GitHub\\QuestTraining\\data.csv";

            try
            {
                var records = ReadCsv(filePath);

                foreach (var record in records)
                {
                    Console.WriteLine($"Id: {record.Id}, Name: {record.Name}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static List<Student> ReadCsv(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = new List<Student>();
                records.AddRange(csv.GetRecords<Student>());
                return records;
            }
        }
    }
}
