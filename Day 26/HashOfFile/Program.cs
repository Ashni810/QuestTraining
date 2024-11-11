using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public class Program
{
    //    public static void Main()
    //    {
    //        string filePath = @"C:\Users\ashni\OneDrive\Documents\hi hellooo guys.....txt";

    //        // Compute MD5 hash of the file
    //        string md5Hash = ComputeFileHash<MD5CryptoServiceProvider>(filePath);
    //        Console.WriteLine("MD5 Hash: " + md5Hash);

    //        // Compute SHA-256 hash of the file
    //        string sha256Hash = ComputeFileHash<SHA256CryptoServiceProvider>(filePath);
    //        Console.WriteLine("SHA-256 Hash: " + sha256Hash);
    //    }

    //    public static string ComputeFileHash<T>(string filePath) where T : HashAlgorithm, new()
    //    {
    //        using (var hashAlgorithm = new T())
    //        {
    //            using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
    //            {
    //                byte[] hash = hashAlgorithm.ComputeHash(fileStream);
    //                StringBuilder hashString = new StringBuilder();
    //                foreach (byte item in hash)
    //                {
    //                    hashString.Append(item.ToString("X2"));
    //                }
    //                return hashString.ToString();
    //            }
    //        }
    //   }
    //public static void Main()
    //{
    //    var path = @"C:\Users\ashni\OneDrive\Documents\hi hellooo guys.....txt";
    //    var bufferedStream = new BufferedStream(File.OpenRead(path), 1024);
    //    var checksum = new SHA256CryptoServiceProvider().ComputeHash(bufferedStream);
    //    var output = BitConverter.ToString(checksum).Replace("-", "");
    //    bufferedStream.Close();
    //    Console.WriteLine(output);
    //}
   
    static void Main()
    {
        Console.WriteLine("Enter a number to generate its multiplication table:");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Multiplication table for {number}:");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }
}


