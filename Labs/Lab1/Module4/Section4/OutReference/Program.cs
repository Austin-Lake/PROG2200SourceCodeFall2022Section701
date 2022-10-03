namespace OutReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 2;
            Console.WriteLine(x);
            Five(out x);
            Console.WriteLine(x);

            var test = "1.5";
            var outDouble = 0.0;
            Console.WriteLine("Result: {0}", parseDouble(test, out outDouble));
            Console.WriteLine("Test type is {0}", outDouble.GetType());
            Console.WriteLine("Test value is {0}", outDouble);
            test = "Austin";
            outDouble = 0.0;
            Console.WriteLine("Result: {0}", parseDouble(test, out outDouble));
            Console.WriteLine("Test type is {0}", outDouble.GetType());
            Console.WriteLine("Test value is {0}", outDouble);

        }

        static void Five(out int a) 
        {
            a = 5;
            Console.WriteLine(a);
        }

        static bool parseDouble(string input, out double outDouble) 
        {
            outDouble = 0.0;

            try
            {
                if (double.Parse(input).GetType() == outDouble.GetType())
                {
                    outDouble = double.Parse(input);
                    return true;
                }
            }
            catch (FormatException)
            { 
            
            }

            return false;
        }
    }
}