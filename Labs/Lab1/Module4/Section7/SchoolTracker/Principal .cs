using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    internal class Principal : Member, IPayee
    {
        public void Pay()
        {
            Console.WriteLine("Paying Principal...");
        }
    }
}
