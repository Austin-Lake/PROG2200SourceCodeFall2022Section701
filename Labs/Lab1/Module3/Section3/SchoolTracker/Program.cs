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
                try
                {
                    var student = new Student();

                    student.name = Util.Console.Ask("Enter Student's Name: ");

                    student.grade = Util.Console.AskInt("Enter Student's Grade: ");

                    student.birthday = Util.Console.Ask("Enter Student's Birthday: ");

                    student.address = Util.Console.Ask("Enter Student's Address: ");

                    student.Phone = Util.Console.AskLong("Enter Student's Phone Number: ");

                    students.Add(student);
                    Student.count++;
                    Console.WriteLine(Student.count);

                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                    {
                        adding = false;
                    }
                }
                catch (FormatException message)
                {
                    Console.WriteLine(message.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("Error adding student, please try again.");
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}, Birthday: {2}, Address: {3}, Phone: {4}",
                                    student.name, student.grade, student.birthday, student.address, student.Phone);
            }
        }

        static void Import()
        {
            var importedStudent = new Student("Tom", 60, "May 2nd, 2002", "123 Sackville St", 1234567);
            Console.WriteLine(importedStudent.name);
        }
    }

    class Member 
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
    class Student : Member
    {
        public static int count;
       
        public int grade;
        public string birthday;
        
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

    class Teacher : Member
    {
        public string subject;
    }
}