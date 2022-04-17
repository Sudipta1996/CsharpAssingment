using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOOPClassAssignment
{
    public class Employee
    {

       public int EmpNo { 
            get;
            set;
        }
        public string EmpName { 
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
        public  void calculateSalary()
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
    
}