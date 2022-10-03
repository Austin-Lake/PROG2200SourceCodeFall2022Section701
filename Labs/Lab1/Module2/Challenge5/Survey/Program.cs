namespace Survey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            Console.WriteLine("What is your name?");
            person.name = TryAnswer();

            Console.WriteLine("What is your age?");
            person.age = TryAnswer();

            Console.WriteLine("What day were you born on?");
            person.day = TryAnswer();

            Console.WriteLine("What month were you born in?");
            person.month = TryAnswer();

            Console.WriteLine("What year were you born in?");
            person.year = TryAnswer();

            string personDate = person.ConvertMonth() + person.day;

            person.Display();

            switch (int.Parse(personDate)) 
            {
                case >= 0101 and <= 0119:
                    Console.WriteLine("You are a Capricorn!");
                    break;

                case >= 0120 and <= 0218:
                    Console.WriteLine("You are a Aquarius!");
                    break;

                case >= 0219 and <= 0320:
                    Console.WriteLine("You are a Pisces!");
                    break;

                case >= 0321 and <= 0419:
                    Console.WriteLine("You are an Aries!");
                    break;

                case >= 0420 and <= 0520:
                    Console.WriteLine("You are a Taurus!");
                    break;

                case >= 0521 and <= 0620:
                    Console.WriteLine("You are a Gemini!");
                    break;

                case >= 0621 and <= 0722:
                    Console.WriteLine("You are a Cancer!");
                    break;

                case >= 0723 and <= 0822:
                    Console.WriteLine("You are a Leo!");
                    break;

                case >= 0823 and <= 0922:
                    Console.WriteLine("You are an Virgo!");
                    break;

                case >= 0923 and <= 1022:
                    Console.WriteLine("You are a Libra!");
                    break;

                case >= 1023 and <= 1121:
                    Console.WriteLine("You are a Scorpio!");
                    break;

                case >= 1122 and <= 1221:
                    Console.WriteLine("You are a Sagittarius!");
                    break;

                case >= 1222 and <= 1231:
                    Console.WriteLine("You are a Capricorn!");
                    break;

                default:
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

    public class Person 
    {
        public string name;
        public string age;
        public string day;
        public string month;
        public string year;

        public void Display() 
        {
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("You were born on {0} {1}, {2}", month, day, year);
        }

        public string ConvertMonth() 
        {
            string convertedMonth;

            switch (month.ToLower())
            {
                case "january":
                    return convertedMonth = "01";
                    
                case "february":
                    return convertedMonth = "02";

                case "march":
                    return convertedMonth = "03";

                case "april":
                    return convertedMonth = "04";

                case "may":
                    return convertedMonth = "05";

                case "june":
                    return convertedMonth = "06";

                case "july":
                    return convertedMonth = "07";

                case "august":
                    return convertedMonth = "08";

                case "september":
                    return convertedMonth = "09";

                case "october":
                    return convertedMonth = "10";

                case "november":
                    return convertedMonth = "11";

                case "december":
                    return convertedMonth = "12";

                default:
                    Console.WriteLine("Month doesn't exist...");
                    return "";
            }
        }
    }
}