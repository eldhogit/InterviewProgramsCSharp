using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVairableDemo
{
    public class NonStaticVariable
    {
        public int i = 5;
        public void test()
        {
            i = i + 5;
            Console.WriteLine(i);
        }

        public static void demo()
        {
            ////
        }
    }

    public class StaticVariable
    {
        public static int i = 5;
        public void test()
        {
            i = i + 5;
            Console.WriteLine(i);
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("/////////// Non Static Variable /////////////");

            NonStaticVariable var = new NonStaticVariable();
            var.test();
            NonStaticVariable var1 = new NonStaticVariable();
            var1.test();
            NonStaticVariable.demo();
            Console.ReadKey();

            Console.WriteLine("/////////// Static Variable /////////////");


            StaticVariable oStaticVariable1 = new StaticVariable();
            oStaticVariable1.test();
            StaticVariable oStaticVariable2 = new StaticVariable();
            oStaticVariable2.test();
            Console.ReadKey();



        }
    }


}
