using System;


namespace Testdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee(1, "Raju", "Upa");
            //employee.Display();
            Calculate calculate = new Calculate();
            //calculate.add(1,2);
            //calculate.add(2,4);
            Console.WriteLine("result is" + calculate.add(1, 2, 3));
            Console.WriteLine("result is" + calculate.add(1.5,2.7,3.4));
            Car c = new Car();
            c.car();
            Head head = new Head();
            head.name();
            head.school();
            Employee employee = new Employee();
            employee.list();
            //IDisplay display = new IDisplay();//cannot create a instance of interface//
            Display display = new Display();
            display.salary();
            Empolyee1 empolyee1 = new Empolyee1(1, "raju", 7800);
            empolyee1.Display();
            Manager manager = new Manager(1, "Pravas", 15000, 42);
            manager.Display();
            Add add = new Add();
            add.sum();

            Console.ReadKey();

        }
    }
}
