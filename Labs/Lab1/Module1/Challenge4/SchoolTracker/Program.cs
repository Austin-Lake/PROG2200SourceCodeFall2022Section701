using System;

namespace SchoolTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in a class");
            int studentCount = int.Parse(Console.ReadLine());

            var students = new string[studentCount, 2];

            for (int i = 0; i < studentCount; i++)
            { 
                Console.WriteLine("Enter Student's Name: ");
                students[i, 0] = Console.ReadLine();


                Console.WriteLine("Enter Student's Grade: ");
                students[i, 1] = Console.ReadLine();
            }

            for (int i = 0; i < studentCount; i++) 
            {
                Console.WriteLine("Name: {0}, Grade: {1}", students[i, 0], students[i, 1]);
            }
        }
    }
}