using System;
using System.Collections.Generic;
using System.Text;

namespace Testdemo
{
    internal class Add
    {
        public void sum()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + b);   
            Console.ReadKey();
        }
    }
}
