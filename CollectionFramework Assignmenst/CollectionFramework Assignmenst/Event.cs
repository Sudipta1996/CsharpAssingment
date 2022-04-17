using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework_Assignmenst
{
     class Event
    {
        
//Step 1. Declare a delegate with the signature of the encapsulated method
public delegate void MyDelegate(string input);
    //Step 2. Define methods that match with the signature of delegate declaration
    class MyClass1
    {
        public void delegateMethod1(string input)
        {
            Console.WriteLine("This is delegateMethod1 and the input to the method is {0}", input);
        }
        public void delegateMethod2(string input)
        {
            Console.WriteLine("This is delegateMethod2 and the input to the method is {0}", input);
        }
    }
    //Step 3. Create delegate object and plug in the methods
    class MyClass2
    {
        public MyDelegate createDelegate()
        {
            MyClass1 c2 = new MyClass1();
            MyDelegate d1 = new MyDelegate(c2.delegateMethod1);
            MyDelegate d2 = new MyDelegate(c2.delegateMethod2);
            MyDelegate d3 = d1 + d2;
            return d3;
        }
    }
    //Step 4. Call the encapsulated methods through the delegate
    class MyClass3
    {
        public void callDelegate(MyDelegate d, string input)
        {
            d(input);
        }
    }
    class Driver
    {
        static void Main(string[] args)
        {
            MyClass2 c2 = new MyClass2();
            MyDelegate d = c2.createDelegate();
            MyClass3 c3 = new MyClass3();
            c3.callDelegate(d, "Calling the delegate");
            Console.ReadKey();
        }
    }
}
}
