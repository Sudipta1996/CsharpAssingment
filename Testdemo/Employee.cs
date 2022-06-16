using System;
using System.Collections.Generic;
using System.Text;

namespace Testdemo
{
    public class Employee
    { 
        public int Id { get; set; } 
        public string Name { get; set; }
        public string EmpAdress { get; set; }
        
        
        public void list()
            {
                List<Employee> list = new List<Employee>()
                {
                     new Employee() {Id =1,Name="Raju",EmpAdress="BLR"},
                    new Employee() { Id = 2,Name = "kalu",EmpAdress = "CMN"},
                    new Employee() {Id =3,Name="Modhu",EmpAdress="CRT"},
                    };
                foreach (Employee e in list)
                    Console.WriteLine("Name"+e.Name+ "Id" +e.Id+ "Address" +e.EmpAdress);
              }
        }       

}
//public://access all the code anywhere in public//
//private://access only member of same class//
//Protected://access the member in same class as well as derived class also
//internal://access the current assembly
//ProtectedInternal://access to current assembly and type derived contaning class
