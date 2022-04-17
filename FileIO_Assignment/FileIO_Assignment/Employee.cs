using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIO_Assignment
{
    [Serializable]
    class Employee
    {
        int empNo;
        string empName;
        public Employee(int empNo, string empName)
        {
            this.empNo = empNo;
            this.empName = empName;
        }
    }
    public class SerializeExample
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("E:\\Helo.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Employee s = new Employee(103, "Rajib");
            formatter.Serialize(stream, s);

            stream.Close();
            Console.ReadKey();
        }

    }
}

