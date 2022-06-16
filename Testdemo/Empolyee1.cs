using System;
using System.Collections.Generic;
using System.Text;

namespace Testdemo
{
    public class Empolyee1
    {
        public int empId { get; set; }
        public string empName { get; set; }
        public int empSal { get; set; }
        
        public Empolyee1(int empId, string empName,int empSal)
        {
            this.empId = empId;
            this.empName = empName;
            this.empSal = empSal;
        }
        public virtual void Display()
        {
            Console.WriteLine("empId"+this.empId+"empName"+this.empName+"empSal"+this.empSal);
        }
        
    }
    public class Manager : Empolyee1
    {
        public int Age { get; set; }
        public Manager(int empId, string empName, int empSal,int Age) : base(empId, empName, empSal)
        {
            this.Age = Age;
        }
        public override void Display()
        {
            Console.WriteLine("empId" + this.empId + "empName" + this.empName + "empSal" + this.empSal+"empAge"+this.Age);
        }
    }
}

