using System;
using System.Collections.Generic;
using System.Text;

namespace TDD_Calculator
{
    class test
    {
        public static bool IsNumberValidTest(string val)
        {
            if (Program.IsNumber(val) == true)
                return true;
            else
                return false;
        }

        public static bool IsNumberInvalidTest(string val)
        {
            if (Program.IsNumber(val) == false)
                return true;
            else
                return false;
        }

        public static bool IsOperatorValidTest(string val)
        {  
            if (Program.IsOperator(val) == true)
                return true;
            else
                return false;
        }

        public static bool IsOperatorInvalidTest(string val)
        {
            if (Program.IsOperator(val) == false)
                return true;
            else
                return false;
        }

        public static void RunTests()
        {
            Console.WriteLine("IsNumberValidTest: "+ Convert.ToString(IsNumberValidTest("5")));
            Console.WriteLine("IsNumberInvalidTest: " + Convert.ToString(IsNumberInvalidTest("q")));
        }
    }
}
