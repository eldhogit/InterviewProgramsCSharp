using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntrfcsWthSameMthdName
{
    public interface ITest1
    {
        void Test();
    }
    public interface ITest2
    {
        void Test();
    }
    public class Dual : ITest1, ITest2
    {
        void ITest1.Test()
        {
            Console.WriteLine("ITest1.Test");
            Console.ReadLine();
        }
        void ITest2.Test()
        {
            Console.WriteLine("ITest2.Test");
            Console.ReadLine();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ITest1 oITest1 = new Dual();
            ITest2 oITest2 = new Dual();

            oITest1.Test();
            oITest2.Test();


        }
    }
}
