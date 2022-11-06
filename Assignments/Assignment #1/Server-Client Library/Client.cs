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
                // Establishes Server and stream connections
                TcpClient client = new TcpClient(server, port);
                NetworkStream stream = client.GetStream();
                Console.WriteLine("Client is connected to Server!");

                // Default initialized member variables
                string clientInput = "";
                bool exit = false;
                bool insert = false;
                Byte[] bytes = new Byte[256];
                byte[] data = new byte[256];

                // Keeps reiterating while Server connection exists 
                while (Server.isClientConnected(client))
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
                        exit = key.Key == ConsoleKey.Escape;
                        insert = key.Key == ConsoleKey.I;
                        // Breaks out of program if Escape key is pressed
                        if (exit) 
                        {
                            Console.WriteLine("You pressed the Escape key to exit.");
                            break;
                        }
                        else if (!insert)
                            continue;
                    }
                    else
                        continue;
                    // Enters insert mode and reads user input
                    Console.Write("Insertion Mode>>");
                    clientInput = Console.ReadLine();
                    exit = clientInput.ToLower().Equals("quit");
                    // Breaks out of program if the word "Quit" is entered
                    if (exit)
                    {
                        Console.WriteLine("You typed Quit to exit.");
                        break;
                    }
                    // Encodes client's input into byte format and writes it to the data stream
                    data = System.Text.Encoding.ASCII.GetBytes(clientInput);
                    stream.Write(data, 0, data.Length);
                           
                }
                // Closes the stream and Server connections 
                stream.Close();
                client.Close();
                Console.WriteLine("Disconnected");
                Console.WriteLine("Good Bye!");
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
