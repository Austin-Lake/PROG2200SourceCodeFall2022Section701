using SchoolTracker;
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

        public static string Ask(int question)
        {
            System.Console.WriteLine(question);
            return System.Console.ReadLine();
        }

        public static int AskInt(string question) 
        {
            try
            {
                System.Console.WriteLine(question);
                return int.Parse(System.Console.ReadLine());
            }
            catch (Exception)
            {
                throw new MyCustomException("Error, Input was not a number");
            }
        }

        public static long AskLong(string question)
        {
            try
            {
                System.Console.WriteLine(question);
                return long.Parse(System.Console.ReadLine());
            }
            catch (Exception)
            {
                throw new MyCustomException("Error, Input was not a number");
            }
        }
    }
}
