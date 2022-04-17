using System;
using System.IO;

namespace FileIO_Assignment
{
     class FileIo
    {
        static void WriteFile(string Filename)
        {
            File.WriteAllText(Filename, "This Is File Io now i am work with this");
            FileStream fs = new FileStream(Filename, FileMode.Create, FileAccess.Write);
            fs.Flush();
            fs.Close();
        }
        static void ReadFile(string Filename)
        {
            Console.WriteLine(File.ReadAllText(Filename));
        }
        static void Main(string[] args)
        {
            string Filename = @"E:\test\mydoc1.txt";
            WriteFile(Filename);
            ReadFile(Filename);
            Console.ReadKey();
        }
    }
}
