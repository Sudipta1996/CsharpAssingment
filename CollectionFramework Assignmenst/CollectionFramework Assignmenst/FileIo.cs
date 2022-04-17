using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CollectionFramework_Assignmenst
{
    class FileIo
    {
        static void WriteFile(string Filename)
        {
            File.WriteAllText(Filename, "This Is File Io now i am work with this");
            FileStream fs = new FileStream (Filename,FileMode.Create,FileAccess.Write);
            fs.Flush();
            fs.Close();
        }
        static void ReadFile(string Filename)
        {
            Console.WriteLine(File.ReadAllText(Filename));
        }
        static void Main(string[] args)
        {
            string Filename = @"E:\test\mydoc.txt";
            WriteFile(Filename);
            ReadFile(Filename);
            Console.ReadKey();
        }
    }
}
