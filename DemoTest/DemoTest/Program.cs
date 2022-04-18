using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, i, sum = 0;
            Console.WriteLine("Enter The Number of students");
            m = int.Parse(Console.ReadLine());
            int[] a = new int[m];
            Console.WriteLine("Enter The Marks of Student");
            for (i = 0; i < m; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            int high = a[0];
            for (i = 0; i < m; i++)
            {
                sum += a[i];
                if (a[i] > high)
                {
                    high = a[i];
                }
            }
            double avg = sum / m;

            Console.WriteLine("average is {0}  Highest is {1} ", avg, high);
            Console.ReadLine();


        }
    }
}
