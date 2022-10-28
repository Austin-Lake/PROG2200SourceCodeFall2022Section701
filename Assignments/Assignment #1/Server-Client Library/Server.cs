using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
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


                server.Start();


                string serverInput = "";
                bool insert = false;
                Byte[] bytes = new Byte[256];
                byte[] data = new byte[256];

                while (true)
                {
                    Console.WriteLine("Waiting for a connection... ");

                    TcpClient client = server.AcceptTcpClient();
                    Console.WriteLine("Client is Connected!");

                    NetworkStream stream = client.GetStream();

                    while (isClientConnected(client))
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
                    }

                    // Shutdown and end the connection

                    client.Close();
                    Console.WriteLine("Client Disconnected");
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

        bool isClientConnected(TcpClient client) 
        {
            if (client.Client.Poll(0, SelectMode.SelectRead))
            {
                byte[] buff = new byte[1];
                if (client.Client.Receive(buff, SocketFlags.Peek) == 0)
                    return false;
            }

            return true;
        } 
    }
}
