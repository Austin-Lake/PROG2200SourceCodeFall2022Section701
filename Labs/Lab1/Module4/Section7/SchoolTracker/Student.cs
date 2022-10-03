using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolTracker
{
    internal class Student : Member, IGraduate
    {
        public static int count;

        public int grade;
        public string birthday;
        public School school;
        public string isGraduating;

        public void Graduate() 
        {
            Console.WriteLine("Student: {0} is Graduating!", name);
        }

        public Student()
        {

        }
        public Student(string name, int grade, string birthday, string address, long phone)
        {
            this.name = name;
            this.grade = grade;
            this.birthday = birthday;
            this.address = address;
            Phone = phone;
        }
    }
}
