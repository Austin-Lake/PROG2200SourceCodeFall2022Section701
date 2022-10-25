using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server_Client_Library
{
    public class Client
    {
        public Client(String server, Int32 port)
        {
            try
            {
             
                TcpClient client = new TcpClient(server, port);

                NetworkStream stream = client.GetStream();
                Console.WriteLine("Connected to server!");

                string clientInput = "";
                Console.WriteLine("Type exit to exit program or press the escape key");
                Console.WriteLine("Write a message");
                while (true) 
                {
                    Console.Write(">>");
                    clientInput = Console.ReadLine();
                    bool isKey = false;
                    if (Console.KeyAvailable)
                    {
                        isKey = Console.ReadKey().Equals(ConsoleKey.Escape);
                    }
                    if (!clientInput.Equals("Exit".ToLower()))
                    {
                        Byte[] data = System.Text.Encoding.ASCII.GetBytes(clientInput);
                        stream.Write(data, 0, data.Length);
                        data = new Byte[256];
                        String responseData = String.Empty;
                        Int32 bytes = stream.Read(data, 0, data.Length);
                        responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                        Console.WriteLine("{0}", responseData);
                    }
                    else 
                    {
                        break;
                    }
                }
                stream.Close();
                client.Close();
            }
            catch (ArgumentNullException e)
            {
                Console.WriteLine("ArgumentNullException: {0}", e);
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
        }
    }
}
