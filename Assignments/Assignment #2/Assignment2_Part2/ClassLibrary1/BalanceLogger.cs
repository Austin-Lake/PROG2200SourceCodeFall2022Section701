﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class BalanceLogger
    {
        // This is the implementation of the event balanceChanged 
        public void balanceLog(decimal amount)
        {
            Console.WriteLine("The balance amount is {0}", amount);
        }
    }
}
