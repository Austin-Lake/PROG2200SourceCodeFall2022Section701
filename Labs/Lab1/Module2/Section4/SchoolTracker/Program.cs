using System;
using System.ComponentModel;

namespace SchoolTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            bool adding = true;

            while (adding)
            { 
                var student = new Student();

                Console.WriteLine("Enter Student's Name: ");
                student.name = Console.ReadLine();

                Console.WriteLine("Enter Student's Grade: ");
                student.grade = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Student's Birthday: ");
                student.birthday = Console.ReadLine();

                Console.WriteLine("Enter Student's Address: ");
                student.address = Console.ReadLine();

                Console.WriteLine("Enter Student's Phone Number: ");
                student.Phone = long.Parse(Console.ReadLine());

                students.Add(student);
                Student.count++;
                Console.WriteLine(Student.count);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y") 
                {
                    adding = false;
                }
            }

            foreach (var student in students) 
            {
                Console.WriteLine("Name: {0}, Grade: {1}, Birthday: {2}, Address: {3}, Phone: {4}",
                                    student.name, student.grade, student.birthday, student.address, student.Phone);
            }
        }
    }

    class Student 
    {
        public static int count;

        public string name;
        public int grade;
        public string birthday;
        public string address;
        private long phone;

        public long Phone 
        { 
            set { phone = value; }
            get { return phone; }
        }

        public void SetPhone(long number) 
        {
            phone = number;
        }
    }
}