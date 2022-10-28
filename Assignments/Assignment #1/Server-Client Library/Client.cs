using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading;
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
                bool exit = false;
                bool insert = false;
                Byte[] bytes = new Byte[256];
                byte[] data = new byte[256];


                while (client.Connected)
                {
                    if (stream.DataAvailable)
                    {
                        int i = stream.Read(bytes, 0, bytes.Length);
                        String responseData = String.Empty;
                        responseData = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine(responseData);
                    }


                    Thread.Sleep(1000);

                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo key = Console.ReadKey(true);

                        exit = key.Key == ConsoleKey.Escape;
                        insert = key.Key == ConsoleKey.I;

                        if (exit)
                            break;
                        else if (!insert)
                            continue;
                    }
                    else
                        continue;


                    Console.Write("Insertion Mode >>");
                    clientInput = Console.ReadLine();
                    exit = clientInput.Equals("Exit".ToLower());

                    if (exit)
                        break;

                    data = System.Text.Encoding.ASCII.GetBytes(clientInput);
                    stream.Write(data, 0, data.Length);
                           
                }

                Console.WriteLine("Disconnected from Server");
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
