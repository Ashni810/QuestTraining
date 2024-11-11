//using System;
//using System.Security.Cryptography;
//using System.Text;

//class Program
//{
//    static void Main(string[] args)
//    {
//        string input = "Good Afternoon Everyone";
//        string hash = FindHash(input);

//        Console.WriteLine($"The hash of '{input}' is: {hash}");
//    }

//    static string FindHash(string input)
//    {
//        // Create a SHA256 instance
//        using (SHA256 sha256Hash = SHA256.Create())
//        {
//            // Compute the hash as a byte array
//            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

//            // Convert byte array to a string
//            StringBuilder builder = new StringBuilder();
//            for (int i = 0; i < bytes.Length; i++)
//            {
//                builder.Append(bytes[i].ToString("x2"));
//            }
//            return builder.ToString();
//        }
//    }
//}
using System.Security.Cryptography;
using System.Text;
using System;

public class Program
{
    public static void Main()
    {
        var password = "Pass@123";

        // Convert the password to a byte array
        var input = Encoding.Default.GetBytes(password);

        // Compute MD5 hash
        var hash1 = new MD5CryptoServiceProvider().ComputeHash(input);
        var builder1 = new StringBuilder();
        foreach (var item in hash1)
        {
            builder1.Append(item.ToString("X2"));
        }
        Console.WriteLine("MD5 Hash: " + builder1.ToString());

        // Compute SHA-256 hash
        var hash2 = new SHA256CryptoServiceProvider().ComputeHash(input);
        var builder2 = new StringBuilder();
        foreach (var item in hash2)
        {
            builder2.Append(item.ToString("X2"));
        }
        Console.WriteLine("SHA-256 Hash: " + builder2.ToString());
    }
}
