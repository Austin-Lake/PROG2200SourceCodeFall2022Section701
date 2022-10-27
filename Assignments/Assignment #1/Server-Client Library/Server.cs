using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace Server_Client_Library
{
    public class Server
    {
        public Server(string address, Int32 port)
        {
            TcpListener server = null;
            try
            {   
                IPAddress local = IPAddress.Parse(address);

                // TcpListener server = new TcpListener(port);
                server = new TcpListener(local, port);

                // Start listening for client requests.
                server.Start();

                // Buffer for reading data
                Byte[] bytes = new Byte[256];
                byte[] data = new byte[256];
                string serverInput = "";
                bool insert = false;

                // Enter the listening loop.
                while (true)
                {
                    Console.WriteLine("Waiting for a connection... ");

                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Client is Connected!");

                    NetworkStream stream = client.GetStream();

                    int i = 0;

                    while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                    {


                        Thread.Sleep(500);

                        if (Console.KeyAvailable)
                        {
                            ConsoleKeyInfo key = Console.ReadKey(true);

                            insert = key.Key == ConsoleKey.I;

                            if (!insert)
                                continue;
                        }
                        else
                            continue;


                        Console.Write("Insertion Mode >>");
                        serverInput = Console.ReadLine();


                        data = System.Text.Encoding.ASCII.GetBytes(serverInput);
                        stream.Write(data, 0, data.Length);

                        i = stream.Read(bytes, 0, bytes.Length);
                        String responseData = String.Empty;
                        responseData = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        Console.WriteLine(responseData);
                    }

                    // Shutdown and end the connection
  
                    client.Close();
                }
            }
            catch (SocketException e)
            {
                Console.WriteLine("SocketException: {0}", e);
            }
            finally
            {
                server.Stop();
            }

            Console.WriteLine("\nHit enter to continue...");
            Console.Read();
        }
    }
}
