using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOPClassAssignment
{
     class MainClass
    {
        public delegate void EmployeeDelegate(Employee employee);
        public static void PrintDetails(Employee employee)
        {
            if (employee is Manager)
            {
                Console.WriteLine("Manager Details are:" + employee.EmpName + " " + employee.EmpNo + " " + employee.GrossSalary);
            }
        }
        public static void PrintDetailsMarketingExecutive(Employee employee)
        {
            if (employee is MarketingExecutive)
            {
                Console.WriteLine("Marketing Details are:" + employee.EmpName + " " + employee.EmpNo+  " "  +employee.GrossSalary);
            }
        }
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine(" Enter the id :" );
            employee.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Name : " );
            employee.EmpName = Console.ReadLine();
            Console.WriteLine("Enter  salary For Employee : " );
            employee.Salary = Convert.ToDouble(Console.ReadLine());
            employee.calculateSalary();
            Console.WriteLine("Gross Salary of Employee :" + employee.GrossSalary);
            Console.WriteLine("Net Salary of Employee :" + employee.NetSalary);
            

            Manager manager = new Manager();
            Console.WriteLine("Enter the id of manager: ");
            manager.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of manager: ");
            manager.EmpName = Console.ReadLine();
            Console.WriteLine("Enter the salary of manager: ");
            manager.Salary = Convert.ToDouble(Console.ReadLine());
            manager.calculateSalary();
            Console.WriteLine("Gross Salary of Manager :" + manager.GrossSalary);
            //EmployeeDelegate employeeDelegate = PrintDetails;
            //employeeDelegate(manager);


            MarketingExecutive marketingExecutive = new MarketingExecutive();
            Console.WriteLine("Enter the id of marketingExecutive: ");
            marketingExecutive.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name of marketingExecutive: ");
            marketingExecutive.EmpName = Console.ReadLine();
            Console.WriteLine("Enter the salary of marketingExecutive: ");
            marketingExecutive.Salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the kilometers of marketingExecutive: ");
            marketingExecutive.kilo = Convert.ToDouble(Console.ReadLine());
            marketingExecutive.calculateSalary();
            Console.WriteLine("Gross Salary of MarketingExecutive :" + marketingExecutive.GrossSalary);

            EmployeeDelegate employeeDelegate1 = PrintDetails;
            EmployeeDelegate employeeDelegate2 = PrintDetailsMarketingExecutive;
            EmployeeDelegate employeeDelegate = employeeDelegate1 + employeeDelegate2;
            employeeDelegate(manager);
            employeeDelegate(marketingExecutive);
            Console.ReadKey();

        }
    }
    
}
