using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            var obj1 = Singleton.Instance;
            var obj2 = Singleton.Instance;

            if (obj1 == obj2)
            {
                //
            }
            else
            {
                //
            }

            obj2.WriteError();
            
        }
    }
}
