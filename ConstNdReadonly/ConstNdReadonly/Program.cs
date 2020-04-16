using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstNdReadonly
{
    class Program
    {
        
        const int a = 10;
        readonly int b;
        readonly int d = 55;
        int c;

        public Program()
        {
            b = 45;
            
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.c = 12;

            

            Console.WriteLine("a = {0}", Program.a);
            Console.ReadLine();

            Console.WriteLine("b = {0}", program.b);
            Console.ReadLine();

            Console.WriteLine("d = {0}", program.d);
            Console.ReadLine();

            Console.WriteLine("c = {0}", program.c);
            Console.ReadLine();
        }
    }
}
