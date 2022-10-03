namespace LoopCounting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int targetNumber;
            int targetOriginal;
            int iteration;
            int iterationCount = 5;

            for (iteration = 0; iteration < iterationCount; iteration++) 
            {
                number = 1;
                targetNumber = 10;

                while (number != 0 || targetNumber != 1)
                {
                    Console.WriteLine(number);

                    if (number < targetNumber)
                    {
                        
                        number++;
                    }
                    else if (number == targetNumber && number != 1)
                    {
                        Console.WriteLine(number);
                        
                        targetNumber = 1;
                        number--;
                    }
                    else
                    {
                        
                        number--;
                    }
                }
            }
            
        }
    }
}