using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic2
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class MyGenericClass<T>
    {
        private T genericObj;

        

        public T genericSave(T genericParameter)
        {
            


            if (genericParameter is Customer)
            {
                var c = genericParameter as Customer;
               return T(SaveCustomer(c));


            }

            if (genericParameter is Seller)
            {
                var s = genericParameter as Seller;
                SaveSeller(s);

            }            

        }


        Customer SaveCustomer(Customer customer)
        {
            return new Customer();
        }

        Seller SaveSeller(Seller seller)
        {
           return new Seller();

        }

        public T genericProperty { get; set; }
    }

   

    class Customer
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public string CustomerSavedMsg { get; set; } = "Customer is Saved.";
    }

    class Seller
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
        public string SellerSavedMsg { get; set; } = "Seller is Saved.";
    }
}
