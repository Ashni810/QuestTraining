using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SocketProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ip = IPAddress.Parse("127.0.0.1");
            var port = 8000;

            var listener = new TcpListener(ip, port);
            listener.Start();
            Console.WriteLine($"Server is listening on {ip}:{port}");

            while (true)
            {
                // Accept a client socket
                Socket socket = listener.AcceptSocket();
                Console.WriteLine("Client Connected");

                    while (true)
                    {
                        var buffer = new byte[1024];
                        int dataLength = socket.Receive(buffer);
                        if (dataLength == 0) break; // Exit if client disconnects

                        string message = Encoding.ASCII.GetString(buffer, 0, dataLength);
                        Console.WriteLine($"Message received: {message}");

                        // Echo the message back to the client
                        byte[] responseData = Encoding.ASCII.GetBytes(message);
                        socket.Send(responseData);
                    }

                    Console.WriteLine("Client disconnected.");
                
            }

            // Uncomment below lines if you want to stop the server gracefully
            // listener.Stop();
        }
    }
}