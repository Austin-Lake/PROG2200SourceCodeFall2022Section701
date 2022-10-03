namespace Survey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What day were you born on?");
            var day = TryAnswer();

            Console.WriteLine("What month were you born in?");
            var month = TryAnswer();

            Console.WriteLine("What year were you born in?");
            var year = TryAnswer();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("You were born on {0} {1}, {2}", month, day, year);


            switch (month.ToLower()) 
            {
                case "march":
                    Console.WriteLine("You are an Aries!");
                    break;

                case "april":
                    Console.WriteLine("You are a Taurus!");
                    break;

                case "may":
                    Console.WriteLine("You are a Gemini!");
                    break;

                case "june":
                    Console.WriteLine("You are a Cancer!");
                    break;

                case "july":
                    Console.WriteLine("You are a Leo!");
                    break;

                case "august":
                    Console.WriteLine("You are an Virgo!");
                    break;

                case "september":
                    Console.WriteLine("You are a Libra!");
                    break;

                case "october":
                    Console.WriteLine("You are a Scorpio!");
                    break;

                case "november":
                    Console.WriteLine("You are a Sagittarius!");
                    break;

                case "december":
                    Console.WriteLine("You are a Capricorn!");
                    break;

                case "january":
                    Console.WriteLine("You are a Aquarius!");
                    break;

                case "february":
                    Console.WriteLine("You are a Pisces!");
                    break;

                default:
                    Console.WriteLine("Month doesn't exist...");
                    break;
            }
        }

        static string TryAnswer() 
        {
            var value = Console.ReadLine();

            while (value == "") 
            {
                Console.WriteLine("You didn't write anything, please try again: ");
                value = Console.ReadLine();
            }

            return value;
        }
    }
}