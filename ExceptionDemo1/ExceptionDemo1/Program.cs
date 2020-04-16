using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = 3;
                var b = 0;

                var c = a / b;
            }

            catch (DivideByZeroException e)
            {
                var m = e.Message;
                var t = e.GetType();
            }
            catch (Exception ex) // will not be executed
            {
                var t = ex.GetType().ToString();
            }
        }
    }
}
