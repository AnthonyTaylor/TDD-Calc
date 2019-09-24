using System;

namespace TDD_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            test.RunTests();

            //Console.WriteLine("Please enter a number");
        }

        public static bool IsNumber(string input)
        {
            try
            {
                int result = Int32.Parse(input);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
                return false;
            }
        }
        public static bool IsOperator(string input)
        {
            return true;
        }
    }
}
