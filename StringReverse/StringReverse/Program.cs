using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string sInput = Console.ReadLine();
            string sEmptyString = string.Empty;
            int length = sInput.Length;
            for (int i = length - 1; i >= 0; i--)
            {
                sEmptyString = sEmptyString + sInput[i];
            }

            Console.WriteLine("Reverse : {0} ", sEmptyString);
            Console.ReadLine();
        }
    }
}


