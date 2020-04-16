using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClassCtor
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Base");
            Console.ReadLine();
        }
    }

    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derived");
            Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Derived o = new Derived();
        }
    }
}
