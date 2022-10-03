using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    interface IPayee 
    {
        void Pay();
    }
    internal class Payroll
    {
        List<IPayee> payees = new List<IPayee>();

        public Payroll() 
        {
            payees.Add(new Teacher());
            payees.Add(new Teacher());
            payees.Add(new Principal());
        }
        public void PayAll() 
        {
            foreach (IPayee payee in payees) 
            {
                payee.Pay();
            }
        }
    }
}
