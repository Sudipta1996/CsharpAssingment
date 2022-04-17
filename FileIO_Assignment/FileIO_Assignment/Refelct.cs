using System;
using System.Reflection;

namespace FileIO_Assignment
{
     public class Refelct
    {
        public int empId { get; set; }
        public string empName { get; set; }

        public Refelct(int empId,string empName)
        {
               this.empId = empId;
            this.empName = empName;
        }
        public Refelct()
        {
            this.empId = -1;
            this.empName = string.Empty;
        }
        public void PrintId()
        {
            Console.WriteLine("ID is = {0}",this.empId);
        }
        public void PrintName()
        {
            Console.WriteLine("Name is = {1}", this.empName);
        }
        
    }
    public  class MainClass
        {
        static void Main(String[] args)
        {
            Type type = Type.GetType("FileIO_Assignment.Refelct");
            Console.WriteLine("Full Name OF class {0}",type.FullName);
            PropertyInfo[] properties = type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType +" "+ property.Name);
            }
            Console.WriteLine("Methods in Employee Class");
            MethodInfo[] methods = type.GetMethods();
            foreach (MethodInfo metho in methods)
            {
                Console.WriteLine(metho.ReturnType.Name + " " + metho.Name);
            }

            Console.ReadKey();
        }
        }
}
