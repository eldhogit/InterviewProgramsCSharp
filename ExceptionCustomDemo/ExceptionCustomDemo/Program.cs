using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionCustomDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                dalCustomer dalCustomer = new dalCustomer();
                dalCustomer.Save();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
