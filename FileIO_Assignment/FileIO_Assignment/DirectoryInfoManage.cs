using System;
using System.IO;
namespace FileIO_Assignment
{
     class DirectoryInfoManage
    {
        static void Main(string[] args)
        {
            DriveInfo[] di = DriveInfo.GetDrives();

            Console.WriteLine("Total Partitions");
            Console.WriteLine("---------------------");
            foreach (DriveInfo items in di)
            {
                Console.WriteLine(items.Name);
            }
            Console.Write("\nEnter the Partition::");
            string ch = Console.ReadLine();

            DriveInfo dInfo = new DriveInfo(ch);

            Console.WriteLine("\n");

            Console.WriteLine("Drive Name::{0}", dInfo.Name);
            Console.WriteLine("Total Space::{0}", dInfo.TotalSize);
            Console.WriteLine("Free Space::{0}", dInfo.TotalFreeSpace);
            Console.WriteLine("Drive Format::{0}", dInfo.DriveFormat);
            Console.WriteLine("Volume Label::{0}", dInfo.VolumeLabel);
            Console.WriteLine("Drive Type::{0}", dInfo.DriveType);
            Console.WriteLine("Root dir::{0}", dInfo.RootDirectory);
            Console.WriteLine("Ready::{0}", dInfo.IsReady);

            Console.ReadKey();
        }
    }
}

