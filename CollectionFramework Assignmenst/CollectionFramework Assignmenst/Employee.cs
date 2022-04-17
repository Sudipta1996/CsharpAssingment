using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework_Assignmenst
{
    class Employee 
    {

        
        public int EmpNo
        {
            get;
            set;
        }
        public string EmpName
        {
            get;
            set;
        }
        public double Salary
        {
            get;
            set;
        }
        public double HRA
        {
            get;
            set;
        }
        public double TA
        {
            get;
            set;
        }
        public double DA
        {
            get;
            set;
        }
        public double PF
        {
            get;
            set;
        }
        public double TDS
        {
            get;
            set;
        }
        public double NetSalary
        {
            get;
            set;
        }
        public double GrossSalary
        {
            get;
            set;
        }

        public override string ToString()
        {
            return "Emp No: " + EmpNo + "   Name: " + EmpName + "   Gross Salary: " + GrossSalary;
        }

        public double calculateHra()
        {
            if (Salary < 5000)
            {
                return .1 * Salary;
            }
            else if (Salary < 10000)
            {
                return .15 * Salary;
            }
            else if (Salary < 15000)
            {
                return .20 * Salary;
            }
            else if (Salary < 15000)
            {
                return .25 * Salary;
            }
            else
            {
                return .30 * Salary;
            }
        }
        public double calculateTa()
        {
            if (Salary < 5000)
            {
                return .05 * Salary;
            }
            else if (Salary < 10000)
            {
                return .1 * Salary;
            }
            else if (Salary < 15000)
            {
                return .15 * Salary;
            }
            else if (Salary < 15000)
            {
                return .20 * Salary;
            }
            else
            {
                return .25 * Salary;
            }
        }
        public double calculateDa()
        {
            if (Salary < 5000)
            {
                return .15 * Salary;
            }
            else if (Salary < 10000)
            {
                return .20 * Salary;
            }
            else if (Salary < 15000)
            {
                return .25 * Salary;
            }
            else if (Salary < 15000)
            {
                return .30 * Salary;
            }
            else
            {
                return .35 * Salary;
            }
        }

        public void calculateSalary()
        {
            this.HRA = calculateHra();
            this.TA = calculateTa();
            this.DA = calculateDa();

            this.GrossSalary = this.Salary + this.HRA + this.TA + this.DA;
            this.PF = .1 * this.GrossSalary;
            this.TDS = 0.18 * this.GrossSalary;
            this.NetSalary = this.GrossSalary - (this.PF + this.TDS);

        }

       
    }


    class EmployeeDetails
    {
        static void Main(string[] args)
        {
            string sSearch;
            List<Employee> employeeList = new List<Employee>();
            Console.WriteLine("Enter the details of 1st Employee: ");
            Employee employeeOne = new Employee();
            Console.WriteLine("Id: ");
            employeeOne.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: ");
            employeeOne.EmpName = Console.ReadLine();
            Console.WriteLine("Salary: ");
            employeeOne.Salary = Convert.ToDouble(Console.ReadLine());
            employeeOne.calculateSalary();

            
            Console.WriteLine("Enter the details of 2nd Employee: ");
            Employee employeeTwo = new Employee();
            Console.WriteLine("Id: ");
            employeeTwo.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: ");
            employeeTwo.EmpName = Console.ReadLine();
            Console.WriteLine("Salary: ");
            employeeTwo.Salary = Convert.ToDouble(Console.ReadLine());
            employeeTwo.calculateSalary();

            Console.WriteLine("Enter the details of 3rd Employee: ");
            Employee employeeThree = new Employee();
            Console.WriteLine("Id: ");
            employeeThree.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: ");
            employeeThree.EmpName = Console.ReadLine();
            Console.WriteLine("Salary: ");
            employeeThree.Salary = Convert.ToDouble(Console.ReadLine());
            employeeThree.calculateSalary();

            Console.WriteLine("Enter the details of 4th Employee: ");
            Employee employeeFour = new Employee();
            Console.WriteLine("Id: ");
            employeeFour.EmpNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name: ");
            employeeFour.EmpName = Console.ReadLine();
            Console.WriteLine("Salary: ");
            employeeFour.Salary = Convert.ToDouble(Console.ReadLine());
            employeeFour.calculateSalary();
        

            employeeList.Add(employeeOne);
            employeeList.Add(employeeTwo);
            employeeList.Add(employeeThree);
            employeeList.Add(employeeFour);


            Console.WriteLine("Find the Employee Name");
            sSearch = Console.ReadLine();
            Employee oFind = employeeList.Find(e => e.EmpName.Equals(sSearch));
            if(oFind != null)
            {
                Console.WriteLine("Employee no :" + oFind.EmpNo + "Employee Salary :" +oFind.GrossSalary);
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            Console.WriteLine();
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("Total No of Employees: " + employeeList.Count);
            Console.ReadKey();

        }
    }
    }

