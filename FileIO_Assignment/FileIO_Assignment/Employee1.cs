using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Assignment
{
     class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }    
    }
    class MainCall
    {
        static void Main(String[]args)
        {
            List<Employee1> employeeList = new List<Employee1>();
            Console.WriteLine("Enter the details of 1st Employee: ");
            Employee1 employeeOne = new Employee1();
            Console.WriteLine("Id: ");
            employeeOne.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: ");
            employeeOne.Name = Console.ReadLine();
            
            
            Console.WriteLine("Enter the details of 2nd Employee: ");
            Employee1 employeeTwo = new Employee1();
            Console.WriteLine("Id: ");
            employeeTwo.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: ");
            employeeTwo.Name = Console.ReadLine();
            

            Console.WriteLine("Enter the details of 3rd Employee: ");
            Employee1 employeeThree = new Employee1();
            Console.WriteLine("Id: ");
            employeeThree.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: ");
            employeeThree.Name = Console.ReadLine();
            

            Console.WriteLine("Enter the details of 4th Employee: ");
            Employee1 employeeFour = new Employee1();
            Console.WriteLine("Id: ");
            employeeFour.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: ");
            employeeFour.Name = Console.ReadLine();
            
        

            employeeList.Add(employeeOne);
            employeeList.Add(employeeTwo);
            employeeList.Add(employeeThree);
            employeeList.Add(employeeFour);

            foreach (Employee1 employee in employeeList)
            {
                //Console.WriteLine(employee);
            }
            Console.WriteLine("Total No of Employees: " + employeeList.Count);
            Console.ReadKey();


        }
    }
}
