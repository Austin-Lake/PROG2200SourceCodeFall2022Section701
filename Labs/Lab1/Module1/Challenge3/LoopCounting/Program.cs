using System.Reflection.Metadata.Ecma335;

namespace LoopCounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 1;
            int targetNumber = 10;
            int iteration = 0;
            int maxIteration = 5;
            

            while (iteration < maxIteration) 
            {
                Console.WriteLine(number);

                if (number < targetNumber)
                {
                    number++;
                    continue;
                }
                else if (number > targetNumber)
                {
                    number--;
                    continue;
                }
                else
                {
                    targetNumber = 1;
                    continue;
                }

                targetNumber = 10;
                iteration++;
            }
        }
    }
}