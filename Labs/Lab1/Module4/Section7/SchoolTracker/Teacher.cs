using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    internal class Teacher : Member, IPayee
    {
        public string subject;
        public void Pay()
        {
            Console.WriteLine("Paying Teacher...");
        }
    }
}
