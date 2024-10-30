using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SocketPrograming.Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;

            var listner = new TcpListener(ip, port);
            listner.Start();
            Console.WriteLine($"App is listening on {ip}:{port}");

            Socket socket = listner.AcceptSocket();
            Console.WriteLine("Client Connected ");

             while (true)
             {
                var buffer = new byte[1024];
                var dataLength = socket.Receive(buffer);
                string message = Encoding.ASCII.GetString(buffer, 0, dataLength);
                Console.WriteLine($"Message received {message} ");


                Console.WriteLine("Server: ");
                string response = Console.ReadLine();
                byte[] responseData = Encoding.ASCII.GetBytes(response);
                socket.Send(responseData);
             }
             
            
            
             socket.Close();
             listner.Stop();
        }
    }
}
