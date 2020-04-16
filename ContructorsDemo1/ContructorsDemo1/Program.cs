using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructorsDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer(2);
             //Customer customer1 = new Customer();

            customer.print();
        }
    }
    public class Customer
    {
        private Customer()
        {
            //we can not create obj
            //we can create obj of parameterized ctor
            //cant be inherirted, nested class can inherit
        }

        static Customer()
        {
            //The static constructor for a class executes before any instance of the class is created
            //A static constructor does not take access modifiers or have parameters.
        }

       

        public Customer(int a)
        {

        }

        public void print()
        {

        }
    }

    class MyClass 
    {

    }
}
