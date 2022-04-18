using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FileIO_Assignment
{
    [AttributeUsage(AttributeTargets.Class |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Constructor |
    AttributeTargets.Property, AllowMultiple = true)]
    class SoftwareAtttribute : System.Attribute
    {
        private string ProjectName;
        private string Description;
        private string ClientName;
        private string StartedDate;
        private string EndDate;

        public string projectName  { get; set; }
        public string description  { get; set; }
        public string clientName  { get; set; }
        public string startedDate   { get; set; }
        public string endDate       { get; set; }
        public class HDFC : SoftwareAtttribute
        {
            public void displayAccount(string projectName, string description, string clientname)
            {

                this.Description = description;
                this.ProjectName = projectName;
                this.ClientName = clientname;
                Console.WriteLine("Project Description : " + Description);
                Console.WriteLine("Projectname : " + ProjectName);
                Console.WriteLine("Project Client Name : " + ClientName);

            }
        }

        public class ICICI : SoftwareAtttribute
        {
            public void displayAccount(string description, string projectName, string clientname, string startdate, string enddate)
            {

                this.Description = description;
                this.ProjectName = projectName;
                this.ClientName = clientname;
                this.startedDate = startdate;
                this.EndDate = enddate;
                Console.WriteLine("\nProject Description : " + Description);
                Console.WriteLine("Projectname : " + ProjectName);
                Console.WriteLine("Project Client Name : " + ClientName);
                Console.WriteLine("Project Started Date : " + startedDate);
                Console.WriteLine("Project End Date : \n" + EndDate);
            }
        }

        class MainTest
        {
            static void Main(string[] args)
            {
                HDFC hDFC = new HDFC();
                hDFC.displayAccount("Banking App", "BFSI", "Webskiters");
                ICICI icICI = new ICICI();
                icICI.displayAccount("Banking App", "BFSI", "Loylods BanK", "17-04-2021", "18-04-2022");

                Assembly executing = Assembly.GetExecutingAssembly();
                Type[] type = executing.GetTypes();
                foreach (Type t in type)
                {
                    MethodInfo[] methodInfos = t.GetMethods();
                    {
                        foreach (MethodInfo mi in methodInfos)
                        {
                            Console.WriteLine(mi.Name);
                        }
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
