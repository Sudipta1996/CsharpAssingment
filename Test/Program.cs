using System;
using static Test.Employee;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Service1 service1 = new Service1();
            Client client = new Client(service1);
            client.serveMethod();
            Service2 service2 = new Service2();
            client = new Client(service2);
            client.serveMethod();
            StudentTable studentTable = new StudentTable();
            studentTable.StuList();
            //cannot create of instance of abstract class//
            //Employee employee = new Employee(); 
            PrintOffer printOffer = new PrintOffer();
            string name = "Raju";
            int pay = 7000;
            Console.WriteLine(name + pay);

            Console.WriteLine("Hello World!");
        }
    }
}
