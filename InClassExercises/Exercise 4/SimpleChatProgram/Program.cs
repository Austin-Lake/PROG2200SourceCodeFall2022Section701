using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ChatLib;

namespace SimpleChatProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0 || args[0] == "-client") 
            {
                Console.WriteLine("Client");
                Client client = new Client();
                
            }
            else if (args.Contains("-server")) 
            {
                Console.WriteLine("Server");
                Server server = new Server();
            }
                

            while (true) 
            {
                Console.WriteLine("Listening for messages");
                Thread.Sleep(1000);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userKey = Console.ReadKey();

                    if (userKey.Key == ConsoleKey.Escape)
                        break;

                    if (userKey.KeyChar == 'i')
                        Console.WriteLine($" '{userKey.Key}' is PRESSED >>");
                    else
                        Console.WriteLine($" You typed {userKey.Key}");

                    Console.Beep();
                }
            }
        }
    }
}
