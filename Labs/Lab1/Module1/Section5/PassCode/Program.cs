namespace PassCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrect = false;

            while (!isCorrect) 
            {
                Console.WriteLine("What is the pass code?");
                var passCode = Console.ReadLine();

                if (passCode == "secret")
                {
                    isCorrect = true;
                    Console.WriteLine("Access Granted!");
                    Console.WriteLine("Do you want to change the password? Y/N");
                    var userChoice = Console.ReadLine();

                    if (userChoice.ToUpper() == "Y")
                    {
                        Console.WriteLine("Enter New Password");
                        var newPassCode = Console.ReadLine();
                        passCode = newPassCode;
                    }

                    Console.WriteLine("Your Pass Code is '{0}'", passCode);
                }
                else
                {
                    Console.WriteLine("Access Denied...");
                }
            }
        }
    }
}