using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOPClassAssignment
{
    public class Manager: Employee
    {
        public double petrol {
            get; 
            set;
        }
        public double food  { 
            get; 
            set;
        }
        public double other { 
            get;
            set;
        }

         public void calculateSalary()
        {
            this.petrol = 0.08 * this.Salary;
            this.food = 0.13 * this.Salary;
            this.other = 0.03 * this.Salary;

            base.calculateSalary();

            this.GrossSalary = this.GrossSalary + this.petrol + this.food + this.other;
            
         }
        public  delegate void EmployeeDelegate(int Empno,string EmpName); 
        public void printDetails(int EmpNo,string EmpName)
        {
            Console.WriteLine("Manager id is:" + EmpNo + "Manager Name is:" + EmpName );
        }
    }
    public class MarketingExecutive: Employee
    {
        public double kilo { 
            get;
            set; 
        }
        public double tour  { 
            get; 
            set;
        }
        public double telephone {
            get;
        } = 1000;
        public void calculateSalary()
        {
            this.tour = this.kilo * 5;
            base.calculateSalary();

            this.GrossSalary = this.GrossSalary + this.tour +this.telephone;    

        }
    }
}



