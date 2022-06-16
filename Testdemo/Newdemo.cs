using System;
using System.Collections.Generic;
using System.Text;

namespace Testdemo
{
    public class Newdemo
    {
        public virtual void car()
        {
            Console.WriteLine("Audi IS created");
        }
        
    }
    public class Car : Newdemo
    {
        public override void car()
        {
            Console.WriteLine("BMW IS created");
        }
    }
}
