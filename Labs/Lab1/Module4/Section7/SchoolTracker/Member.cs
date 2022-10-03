using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    internal class Member
    {
        public string name;
        public string address;
        protected long phone;

        public long Phone
        {
            set { phone = value; }
            get { return phone; }
        }
    }
}
