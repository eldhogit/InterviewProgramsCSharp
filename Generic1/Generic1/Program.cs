using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic1
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer ObjCustomer = new Customer();
            Seller ObjSeller = new Seller();
            DAL.Save(ObjSeller);
        }


    }

    public static class DAL
    {
        public static void Save<T>(T request) where T : class
        {
            if (request is Customer)
            {
                var c = request as Customer;
                SaveCustomer(c);
            }

            if (request is Seller)
            {
                var s = request as Seller;
                SaveSeller(s);
            }
        }
        static void SaveCustomer(Customer customer)
        {
            Console.WriteLine("Customer is Saved.");
            Console.ReadLine();
        }

        static void SaveSeller(Seller seller)
        {
            Console.WriteLine("Seller is Saved.");
            Console.ReadLine();

        }
    }

    class Customer
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }
    }

    class Seller
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public int MyProperty3 { get; set; }
    }


}
