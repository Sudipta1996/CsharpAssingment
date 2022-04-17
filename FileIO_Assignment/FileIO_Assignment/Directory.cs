using System;
using System.IO;
namespace FileIO_Assignment
{
    class Directory
    {
        static void Main(string[] args)
        {
            String path = @"D:\MyTestFile2.txt";
            DirectoryInfo fl = new DirectoryInfo(path);
            fl.Create();
            {
                Console.WriteLine("Directory has been created");
            }
            Console.ReadLine();
           
        }
    }
}  
       

