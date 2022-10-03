namespace Survey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();

            person.name = TryAnswer("What is your name?");
            person.age = TryAnswer("What is your age?");
            person.day = TryAnswer("What day were you born on?");
            person.month = TryAnswer("What month were you born in?");
            person.year = TryAnswer("What year were you born in?");

            string personDate = person.ConvertMonth() + person.day;

            person.Display();

            switch (int.Parse(personDate)) 
            {
                case >= 101 and <= 119:
                    Console.WriteLine("You are a Capricorn!");
                    break;
                case >= 120 and <= 218:
                    Console.WriteLine("You are a Aquarius!");
                    break;
                case >= 219 and <= 320:
                    Console.WriteLine("You are a Pisces!");
                    break;
                case >= 321 and <= 419:
                    Console.WriteLine("You are an Aries!");
                    break;
                case >= 420 and <= 520:
                    Console.WriteLine("You are a Taurus!");
                    break;
                case >= 521 and <= 620:
                    Console.WriteLine("You are a Gemini!");
                    break;
                case >= 621 and <= 722:
                    Console.WriteLine("You are a Cancer!");
                    break;
                case >= 723 and <= 822:
                    Console.WriteLine("You are a Leo!");
                    break;
                case >= 823 and <= 922:
                    Console.WriteLine("You are an Virgo!");
                    break;
                case >= 923 and <= 1022:
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

        static string TryAnswer(string message) 
        {
            Console.WriteLine(message);
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

        enum Months 
        {
            JANUARY = 1,
            FEBRUARY,
            MARCH,
            APRIL,
            MAY,
            JUNE,
            JULY,
            AUGUST,
            SEPTEMBER,
            OCTOBER,
            NOVEMBER,
            DECEMBER,
        }

        public void Display() 
        {
            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("You were born on: {0} {1}, {2}", month, day, year);
        }

        public string ConvertMonth() 
        {
            int isDigit;
            int.TryParse(month, out isDigit);
            string convertedMonth = "";

            if (isDigit != 0)
            {
                switch ((Months)int.Parse(month))
                {
                    case Months.JANUARY:
                        month = "January";
                        convertedMonth = "1";
                        break;
                    case Months.FEBRUARY:
                        month = "February";
                        convertedMonth = "2";
                        break;
                    case Months.MARCH:
                        month = "March";
                        convertedMonth = "3";
                        break;
                    case Months.APRIL:
                        month = "April";
                        convertedMonth = "4";
                        break;
                    case Months.MAY:
                        month = "May";
                        convertedMonth = "5";
                        break;
                    case Months.JUNE:
                        month = "June";
                        convertedMonth = "6";
                        break;
                    case Months.JULY:
                        month = "July";
                        convertedMonth = "7";
                        break;
                    case Months.AUGUST:
                        month = "August";
                        convertedMonth = "8";
                        break;
                    case Months.SEPTEMBER:
                        month = "September";
                        convertedMonth = "9";
                        break;
                    case Months.OCTOBER:
                        month = "October";
                        convertedMonth = "10";
                        break;
                    case Months.NOVEMBER:
                        month = "November";
                        convertedMonth = "11";
                        break;
                    case Months.DECEMBER:
                        month = "December";
                        convertedMonth = "12";
                        break;
                    default:
                        Console.WriteLine("Month doesn't exist...");
                        break;
                }

                return convertedMonth;
            }
            else
            {
                switch (month.ToLower())
                {
                    case "january":
                        convertedMonth = "1";
                        break;
                    case "february":
                        convertedMonth = "2";
                        break;
                    case "march":
                        convertedMonth = "3";
                        break;
                    case "april":
                        convertedMonth = "4";
                        break;
                    case "may":
                        convertedMonth = "5";
                        break; 
                    case "june":
                        convertedMonth = "6";
                        break;
                    case "july":
                        convertedMonth = "7";
                        break;
                    case "august":
                        convertedMonth = "8";
                        break;
                    case "september":
                        convertedMonth = "9";
                        break;
                    case "october":
                        convertedMonth = "10";
                        break;
                    case "november":
                        convertedMonth = "11";
                        break;
                    case "december":
                        convertedMonth = "12";
                        break;
                    default:
                        Console.WriteLine("Month doesn't exist...");
                        break;
                }

                month = char.ToUpper(month[0]) + month.Substring(1);
                return convertedMonth;
            }
        }
    }
}