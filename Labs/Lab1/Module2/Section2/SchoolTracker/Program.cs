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
                student.Name = Console.ReadLine();

                Console.WriteLine("Enter Student's Grade: ");
                student.Grade = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Student's Birthday: ");
                student.Birthday = Console.ReadLine();

                Console.WriteLine("Enter Student's Address: ");
                student.Address = Console.ReadLine();

                Console.WriteLine("Enter Student's Phone Number: ");
                student.SetPhone(long.Parse(Console.ReadLine()));

                students.Add(student);

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y") 
                {
                    adding = false;
                }
            }

            foreach (var student in students) 
            {
                Console.WriteLine("Name: {0}, Grade: {1}, Birthday: {2}, Address: {3}, Phone: {4}",
                                    student.Name, student.Grade, student.Birthday, student.Address, student.GetPhone());
            }
        }
    }

    class Student 
    {
        public string Name;
        public int Grade;
        public string Birthday;
        public string Address;
        private long Phone;

        public void SetPhone(long number) 
        {
            Phone = number;
        }

        public long GetPhone() 
        {
            return Phone;
        }
    }
}