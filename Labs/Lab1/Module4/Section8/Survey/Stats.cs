using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey
{
    internal class Stats
    {
        public void Start() 
        {
            Program.Posted += HasPosted;
        }

        void HasPosted() 
        {
            Console.WriteLine("Survey posted, run stats");
        }
    }
}
