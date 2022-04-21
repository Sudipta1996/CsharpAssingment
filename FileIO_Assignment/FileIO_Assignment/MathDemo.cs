using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Assignment
{
     class MathDemo
    {
        static int Cube(int n)
        {

            return n * n * n;
        }
        static void Main(String[]args)
        {
            Console.WriteLine(Cube(5));
            Console.ReadKey();
        }
    }
}
