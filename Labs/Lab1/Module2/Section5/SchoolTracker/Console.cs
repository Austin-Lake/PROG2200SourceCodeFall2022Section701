using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    internal class Console
    {
        public static string Ask(string question) 
        {
            System.Console.WriteLine(question);
            return System.Console.ReadLine();
        }
    }
}
