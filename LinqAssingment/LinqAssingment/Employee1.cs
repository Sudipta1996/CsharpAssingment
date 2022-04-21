using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAssingment
{
    class Employee1
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }
    }
    class MainCall
    {
         public static List<Employee1> employeeList = new List<Employee1>
      { 
            new Employee1() { EmployeeID = 1001,FirstName = "Malcolm",LastName = "Daruwalla",Title = "Manager",DOB = DateTime.Parse("1984-01-02"),DOJ = DateTime.Parse("2011-08-09"),City = "Mumbai"},
new Employee1() { EmployeeID = 1002,FirstName = "Asdin",LastName = "Dhalla",Title = "AsstManager",DOB = DateTime.Parse("1984-08-20"),DOJ = DateTime.Parse("2012-7-7"),City = "Mumbai"},
new Employee1() { EmployeeID = 1003,FirstName = "Madhavi",LastName = "Oza",Title = "Consultant",DOB = DateTime.Parse("1987-11-14"),DOJ = DateTime.Parse("2015-4-12"),City = "Pune"},
new Employee1() { EmployeeID = 1004,FirstName = "Saba",LastName = "Shaikh",Title = "SE",DOB = DateTime.Parse("6/3/1990"),DOJ = DateTime.Parse("2/2/2016"),City = "Pune"},
new Employee1() { EmployeeID = 1005,FirstName = "Nazia",LastName = "Shaikh",Title = "SE",DOB = DateTime.Parse("3/8/1991"),DOJ = DateTime.Parse("2/2/2016"),City = "Mumbai"},
new Employee1() { EmployeeID = 1006,FirstName = "Suresh",LastName = "Pathak",Title = "Consultant",DOB = DateTime.Parse("11/7/1989"),DOJ = DateTime.Parse("8/8/2014"),City = "Chennai"},
new Employee1() { EmployeeID = 1007,FirstName = "Vijay",LastName = "Natrajan",Title = "Consultant",DOB = DateTime.Parse("12/2/1989"),DOJ = DateTime.Parse("6/1/2015"),City = "Mumbai"},
new Employee1() { EmployeeID = 1008,FirstName = "Rahul",LastName = "Dubey",Title = "Associate",DOB = DateTime.Parse("11/11/1993"),DOJ = DateTime.Parse("11/6/2014"),City = "Chennai"},
new Employee1() { EmployeeID = 1009,FirstName = "Amit",LastName = "Mistry",Title = "Associate",DOB = DateTime.Parse("8/12/1992"),DOJ = DateTime.Parse("12/3/2014"),City = "Chennai"},
new Employee1() { EmployeeID = 1010,FirstName = "Sumit",LastName = "Shah",Title = "Manager",DOB = DateTime.Parse("4/12/1991"),DOJ = DateTime.Parse("1/2/2016"),City = "Pune"},

};
        
        public static void DisplayAll()
        {
            var query = (from s in employeeList
                         select s);
            foreach (var item in query)
            {
                Console.WriteLine(item.EmployeeID+" "+item.FirstName+" "+item.LastName+" "+item.Title+" "+item.DOB+" "+item.DOJ+" "+item.City);
            }
        }
        public static void NotMumbai()
        {
            var query = (from s in employeeList
                         where s.City != "Mumbai"
                         select s);
            foreach (var item in query)
            {
                Console.WriteLine(item.EmployeeID);
            }
        }
        public static void TitleManger()
        {
            var query = (from s in employeeList
                         where s.Title == "AsstManager"
                         select s);
            foreach (var item in query)
            {
                Console.WriteLine(item.FirstName);
            }
        }
        public static void LastName()
        {
            var query = (from s in employeeList
                         where s.LastName.StartsWith("S")
                         select s);
            foreach (var item in query)
            {
                Console.WriteLine(item.EmployeeID);
            }
        }
        public static void BeforDOJ()
        {
            DateTime dt2 = new DateTime(2015, 1, 1);
            var query = (from s in employeeList
                         where s.DOJ < dt2
                         select s);
            foreach (var item in query)
            {
                Console.WriteLine(item.EmployeeID);
            }
        }
        public static void AfterDOB()
        {
            DateTime dt2 = new DateTime(1990, 1, 1);
            var query = (from s in employeeList
                         where s.DOB > dt2
                         select s);
            foreach (var item in query)
            {
                Console.WriteLine(item.EmployeeID + "" + item.FirstName);
            }
        }
        public static void TitleAssociateAndConsultant()
        {
            var query = (from s in employeeList
                         where s.Title == "Associate" || s.Title == "Consultant"
                         select s);
            foreach (var item in query)
            {
                Console.WriteLine(item.LastName);
            }
        }
        public static void TotalEmployee()
        {
            var query = (from s in employeeList
                         select s).Count();
            
                Console.WriteLine(query);
            
        }
        public static void TotalEmployeeChenani()
        {
            var query = (from s in employeeList
                         where s.City == "Chennai"
                         select s).Count();

            Console.WriteLine(query);

        }
        public static void HighestId()
        {
            var query = (from s in employeeList
                         select s.EmployeeID).Max();

            Console.WriteLine(query);

        }
        public static void AfterDOJ()
        {
            DateTime dt2 = new DateTime(2015, 1, 1);
            var query = (from s in employeeList
                         where s.DOJ > dt2
                         select s).Count();
           
                Console.WriteLine(query);
            
        }
        public static void NotAssociate()
        {
            var query = (from s in employeeList
                         where s.Title != "Associate"
                         select s).Count();
            
                Console.WriteLine(query);
            
        }
        public static void TotalEmployeeCity()
        {

            var query = (from s in employeeList
                         group s by s.City);
                         
            foreach (var item in query)
            {
                Console.WriteLine(item.Count());
            }
        }
        //public static void TotalEmployeeCityAndTitle()
        //{

        //    var query = from s in employeeList
        //                 group s by new
        //                 {
        //                     s.Title,
        //                     s.City,
        //                 } into empGrp


        //    foreach (var item in query)
        //    {
        //        Console.WriteLine(item.Count());
        //    }
        //}
        public static void YoungerEmployee()
        {

            var query = employeeList.OrderByDescending(e=>e.DOB).FirstOrDefault();
                        
            Console.WriteLine(query.FirstName);
           
        }

        static void Main(String[] args)
        {
            YoungerEmployee();
            //TotalEmployeeCity();
            //NotAssociate();
            //AfterDOJ();
            //HighestId();
            //TotalEmployeeChenani();
            //TotalEmployee();    
            //AfterDOB();
            //BeforDOJ();
            //TitleAssociateAndConsultant();
            //LastName();
            //TitleManger();
            //DisplayAll();
            //NotMumbai();
            Console.ReadKey();


        }
    }
}
