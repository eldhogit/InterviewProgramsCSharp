using System;
using pone = ProjectOne.TeamOne;
using ptwo = ProjectOne.TeamTwo;

namespace NamespaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectA.TeamA.ClassA.Print();
            ProjectA.TeamB.ClassA.Print();

            pone.ClassOne.Print();
            ptwo.ClassOne.Print();
        }
    }
}

namespace ProjectA
{
    namespace TeamA
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("TeamA Print Method");
                Console.ReadLine();
            }

        }
    }
}

namespace ProjectA
{
    namespace TeamB
    {
        class ClassA
        {
            public static void Print()
            {
                Console.WriteLine("TeamB Print Method");
                Console.ReadLine();
            }

        }
    }
}
