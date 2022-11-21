using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Assignment2_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            PiggyBank pb = new PiggyBank();
            BalanceLogger bl = new BalanceLogger();
            BalanceWatcher bw = new BalanceWatcher();

            // Triggering the balacedChanged event listener. 
            // That means this event is ready to implpement balanceLog method &
            // belanceWatch method once it is called from the setter of the m_bankBalance

            pb.balanceChanged += bl.balanceLog; // By implementing the balanceLog method
            pb.balanceChanged += bw.balanceWatch; // By implementing the balanceWatch method
            pb.negBalanceChanged += delegate(object sender, BalanceArgs e) { if (e.Balance < 0) { Console.WriteLine("Your balance has dropped below zero, your balance is {0}", e.Balance); } };

            string theStr;
            do
            {
                Console.WriteLine("How much to deposit?");

                theStr = Console.ReadLine();
                if (!theStr.Equals("exit"))
                {
                    try
                    {
                        decimal newVal = decimal.Parse(theStr);
                        pb.theBalance += newVal;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Enter a valid numerical value or exit");
                        continue;
                    }
                    catch (OverflowException) 
                    {
                        Console.WriteLine("Numerical value is too big, enter a smaller number");
                        continue; 
                    }
                }
            } while (!theStr.Equals("exit"));
            Console.WriteLine("Your current balance after those transactions is: ${0}",pb.theBalance);
            Console.ReadLine();

        }
    }
}
