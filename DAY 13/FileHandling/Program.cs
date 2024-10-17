using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = @"C:\Users\ashni\OneDrive\Desktop\react"; ;
            var fileName = "data.txt";

            var filePath = Path.Combine(path, fileName);

            //Directory.CreateDirectory(path);

            //File.WriteAllText(filePath, "New Text from code");

            //File.AppendAllText(filePath, "New Text from code");

            //File.AppendAllText(filePath, "New Text from code"); //File.AppendAllText(filePath, "New Text from code");

            //Directory.Delete(path);

            //Directory.Delete(path, true);

            var content = File.ReadAllText(filePath);

            string[] contentLines = File.ReadAllLines(filePath);

            Console.WriteLine(content);



        }
    }
}
