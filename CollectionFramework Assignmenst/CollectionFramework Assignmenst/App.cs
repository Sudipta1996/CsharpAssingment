using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework_Assignmenst
{
    internal class App
    {
        static void Main()
        {
            AppDomain d = AppDomain.CreateDomain("NewDomain");
            Console.WriteLine("Host domain:  " + AppDomain.CurrentDomain.FriendlyName);
            Console.WriteLine("Child domain:  " + d.FriendlyName);
            Console.ReadLine();
        }
    }
}

