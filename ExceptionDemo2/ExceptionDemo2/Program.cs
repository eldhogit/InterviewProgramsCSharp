using BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                balManager obalManager = new balManager();
                obalManager.Method2();
            }
            catch (Exception ex)
            {
                Console.Write(ex.StackTrace.ToString());
                Console.ReadKey();
            }
        }      
    }
}
