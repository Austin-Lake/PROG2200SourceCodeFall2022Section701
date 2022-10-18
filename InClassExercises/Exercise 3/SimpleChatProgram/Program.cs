using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleChatProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Listening for messages");
                Thread.Sleep(1000);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo userKey = Console.ReadKey();

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
