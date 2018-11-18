using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Alphabets
{
    class Program
    {
        static void Main(string[] args)
        {
          l1:Console.WriteLine("Enter string");
            Console.WriteLine($"Number Value {GetNumber(Console.ReadLine().ToUpper())}");
            Console.WriteLine("Press Y to continue or any other key to exit");
            string y = Console.ReadLine();
            if (y.ToUpper() == "Y")
                goto l1;
        }

        static long GetNumber(string strVal)
        {
            int letter_count = 26;
            long result = 0;
            int iterator = 0;
           Array charArray = new char[26] { 'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q',
               'R','S','T','U','V','W','X','Y','Z'};
            char[] charVal = strVal.ToCharArray();
            foreach (char c in charVal)
            {
                result = Array.IndexOf(charArray, c, 0)+1  + result * (iterator * letter_count);
                iterator++;
            }
            return result;
        }
    }
}
