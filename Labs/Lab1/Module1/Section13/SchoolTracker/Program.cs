using System;
using System.ComponentModel;

namespace SchoolTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentNames = new List<string>();
            var studentGrades = new List<int>();

            bool adding = true;

            while (adding)
            { 
                Console.WriteLine("Enter Student's Name: ");
                studentNames.Add(Console.ReadLine());


                Console.WriteLine("Enter Student's Grade: ");
                studentGrades.Add(int.Parse(Console.ReadLine()));

                Console.WriteLine("Add another? y/n");

                if (Console.ReadLine() != "y") 
                {
                    adding = false;
                }
            }

            for (int i = 0; i < studentNames.Count; i++) 
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }
        }
    }
}