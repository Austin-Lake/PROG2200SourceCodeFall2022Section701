using System;
using System.ComponentModel;

namespace SchoolTracker
{
    enum School 
    {
        IT,
        Akerely,
        Truro
    }
    internal class Program
    {
        static List<Student> students = new List<Student>();
        static List<IGraduate> grads = new List<IGraduate>();
        static void Main(string[] args)
        {
            Payroll payroll = new Payroll();
            payroll.PayAll();

            bool adding = true;

            while (adding)
            {
                try
                {
                    var student = new Student();

                    student.name = Util.Console.Ask("Enter Student's Name: ");
                    student.grade = Util.Console.AskInt("Enter Student's Grade: ");
                    student.school = (School) Util.Console.AskInt("School Name (type the corresponding number): \n 0: IT Campus \n 1: Akerley Campus \n 2: Truro Campus \n");
                    student.birthday = Util.Console.Ask("Enter Student's Birthday: ");
                    student.address = Util.Console.Ask("Enter Student's Address: ");
                    student.Phone = Util.Console.AskLong("Enter Student's Phone Number: ");
                    student.isGraduating = Util.Console.Ask("Is Graduating? y/n: ");

                    students.Add(student);

                    if (student.isGraduating == "y")
                    {
                        grads.Add(student);
                    }

                    Student.count++;
                    Console.WriteLine("Students added: {0}", Student.count);

                    Console.WriteLine("Add another? y/n");

                    if (Console.ReadLine() != "y")
                    {
                        adding = false;
                    }
                }
                catch (MyCustomException) 
                {
                   
                }
                catch (Exception)
                {
                    Console.WriteLine("Error adding student, please try again.");
                }
            }

            Registrar registrar = new Registrar(grads);

            foreach (var student in students)
            {
                Console.WriteLine("Name: {0}, Grade: {1}, Birthday: {2}, Address: {3}, Phone: {4}",
                                    student.name, student.grade, student.birthday, student.address, student.Phone);
            }

            Export();
            registrar.GraduateAll();
        }

        static void Import()
        {
            var importedStudent = new Student("Tom", 60, "May 2nd, 2002", "123 Sackville St", 1234567);
            Console.WriteLine(importedStudent.name);
        }

        static void Export() 
        {
            foreach (var student in students) 
            {
                switch (student.school) 
                {
                    case School.IT:
                        Console.WriteLine("Exporting to IT Campus");
                        break;
                    case School.Akerely:
                        Console.WriteLine("Exporting to IT Campus");
                        break;
                    case School.Truro:
                        Console.WriteLine("Exporting to IT Campus");
                        break;
                }
            }
        }
    }

    class MyCustomException : FormatException
    {
        public MyCustomException(string message) 
        {
            Console.WriteLine(message);
        }
    }
}