using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework_Assignmenst
{
     class EmployeeLinkList
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
            return "Emp No :" + EmpNo + "Name :" + EmpName + "Gross Salary :" + GrossSalary;
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
        class EmployeeDetail
        {
            static void Main(String[] args)
            {
                LinkedList<Employee> list = new LinkedList<Employee>();
                Console.WriteLine("Enter the details of 1st Employee: ");
                Employee employeeOne = new Employee();
                Console.WriteLine("Id: ");
                employeeOne.EmpNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name: ");
                employeeOne.EmpName = Console.ReadLine();
                Console.WriteLine("Salary: ");
                employeeOne.Salary = Convert.ToDouble(Console.ReadLine());
                employeeOne.calculateSalary();


                Console.WriteLine("Enter the details of 1st Employee: ");
                Employee employeeTwo = new Employee();
                Console.WriteLine("Id: ");
                employeeTwo.EmpNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Name: ");
                employeeTwo.EmpName = Console.ReadLine();
                Console.WriteLine("Salary: ");
                employeeTwo.Salary = Convert.ToDouble(Console.ReadLine());
                employeeTwo.calculateSalary();

                list.AddLast(employeeOne);
                list.AddLast(employeeTwo);

                Console.WriteLine();
                 foreach (Employee e in list)
                {
                    Console.WriteLine(e);
                }
                 Console.WriteLine("The no of employee Are present :" + list.Count);
                Console.ReadKey();

            }
        }
    }
}
