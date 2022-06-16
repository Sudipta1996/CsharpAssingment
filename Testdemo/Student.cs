using System;
using System.Collections.Generic;
using System.Text;

namespace Testdemo
{
    abstract class Student
    {
        public string Name { get; set; }
        public abstract void name();//no defination abstract method//
        public void school()//normal method//
        {
            Console.WriteLine("This is my school");
        }
    }
    class Head : Student
    {
        public override void name()
        {
            Console.WriteLine("Lucacu");
        }
    }
}
