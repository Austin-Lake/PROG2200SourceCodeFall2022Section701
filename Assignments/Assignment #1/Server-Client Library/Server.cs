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
                // Converts IP address string value into IP Address Object
                IPAddress local = IPAddress.Parse(address);

                // Creates new TCP Listener/Server on specified IP and Port
                server = new TcpListener(local, port);
                // Starts the server
                server.Start();
                // Default initialized member variables 
                string serverInput = "";
                bool insert = false;
                Byte[] bytes = new Byte[256];
                byte[] data = new byte[256];
                // Infinite Loop
                while (true)
                {
                    // Waits and establishes Client and stream connections
                    Console.WriteLine("Waiting for any client connection: ");
                    TcpClient client = server.AcceptTcpClient();
                    NetworkStream stream = client.GetStream();
                    Console.WriteLine("Connection established with Client!");
                    // Keeps reiterating while Client connection exists 
                    while (isClientConnected(client))
                    {
                        // Checks if data is available in the stream
                        if (stream.DataAvailable)
                        {
                            // Reads byte data from stream, converts it into string format, and writes the message to console
                            int i = stream.Read(bytes, 0, bytes.Length);
                            String responseData = String.Empty;
                            responseData = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                            Console.WriteLine(responseData);
                        }

                        // Waits for a second and checks if a key was pressed otherwise reiterates through loop
                        Thread.Sleep(1000);

                        if (Console.KeyAvailable)
                        {
                            // Gets key pressed from console without displaying it
                            ConsoleKeyInfo key = Console.ReadKey(true);
                            // Checks if a special key was pressed
                            insert = key.Key == ConsoleKey.I;

                            if (!insert)
                                continue;
                        }
                        else
                            continue;

                        // Enters insert mode and reads user input
                        Console.Write("Insertion Mode>>");
                        serverInput = Console.ReadLine();

                        // Encodes server's input into byte format and writes it to the data stream
                        data = System.Text.Encoding.ASCII.GetBytes(serverInput);
                        stream.Write(data, 0, data.Length);
                    }

                    // Closes the stream and Client connections, then breaks out of the program
                    stream.Close();
                    client.Close();
                    Console.WriteLine("Application has been disconnected");
                    break;
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
        }
        // Custom method to check whether a current TCP Client connection currently exists

        // Polls the connection to see if it exists and
        // then checks to see if any data is being received in the stream
        public static bool isClientConnected(TcpClient client) 
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
