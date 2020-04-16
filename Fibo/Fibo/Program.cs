using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, first = 0, second = 1, next, i;
            Console.WriteLine("Enter the number");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" First " + n + " terms of Fibo series are : ");

            for ( i = 0; i < n; i++)
            {
                if (i <= 1)
                    next = i;
                else
                {
                    next = first + second;                    
                    first = second;
                    second = next;
                }
                Console.WriteLine(next);
            }
            Console.ReadLine();
        }
    }
}
