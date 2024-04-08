using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File_Handling
    {
        internal class Program
        {
            //Create a folder
            static void m1()
            {
                string folder = @"E:\\Demo123";
                try
                {
                    Directory.CreateDirectory(folder);
                    Console.WriteLine("Directory is Created");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            //Delete a folder
            //static void m2()
            //{
            //    string mydir = @"E:\\Mydir";
            //    try
            //    {
            //        if (Directory.Exists(mydir))
            //        {
            //            Directory.Delete(mydir);
            //            Console.WriteLine("Folder deleted....");
            //        }
            //        else
            //        {
            //            Directory.CreateDirectory(mydir);
            //            Console.WriteLine("Folder is created....");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}

            //DirectoryInfo
            //static void m3()
            //{
            //    string path = @"Demo";
            //    DirectoryInfo d = new DirectoryInfo(path);
            //    d.Create();
            //    Console.WriteLine("Folder is created......");
            //}

            static void Main(string[] args)
            {
            m1();
               //m2();
            //   m3();
            }
        }
    }

