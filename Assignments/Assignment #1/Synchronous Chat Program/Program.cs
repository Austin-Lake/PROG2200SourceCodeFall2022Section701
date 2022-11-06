using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Server_Client_Library;


namespace Synchronous_Chat_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Int32 port = 13000;
            string address = "127.0.0.1";

            if (args.Length == 0 || args[0].ToLower() == "-client")
            {
                new Client(address, port);
            }
            else if (args[0].ToLower() == "-server") 
            {
                new Server(address, port);
            }
        }
    }
}
