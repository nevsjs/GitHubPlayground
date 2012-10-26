using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.Foo();
            c1.Foo3();

            Class1 c2 = new Class1();
            c2.Foo();
            c2.Foo2();
        }
    }
}
