namespace JobCandidate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years experience do you have?");

            int years = int.Parse(Console.ReadLine());

            switch (years) 
            {
                case 0:
                    Console.WriteLine("Inexperienced");
                    break;

                case 1:
                    Console.WriteLine("Junior");
                    break;

                case 2:
                    Console.WriteLine("Intermediate");
                    break;

                case 3:
                    Console.WriteLine("Advanced");
                    break;

                default:
                    Console.WriteLine("Senior");
                    break;
            }
        }
    }
}