using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fileexample
{
    class Program
    {
        static void Main(string[] args)
        {
           


            string path = @"C:\Users\Admin\Desktop\test1.txt";
            if (!File.Exists(path))
            {
                ///CREATE A FILE TO WRITE TO
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("enter your name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your city");
                    string city = Console.ReadLine();
                    Console.WriteLine("enter your id ");
                    string id = Console.ReadLine();
                    sw.WriteLine("my name is " + name);
                    sw.WriteLine("my city is " + city);
                    sw.WriteLine("my emp id is " + id);
                    sw.Flush();
                }
            }
          
            //open the file to read from
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)


                {
                    Console.WriteLine(s);
                }
            }
           // fileappend();
        }




        private static void fileappend()
        {
            string path = @"C:\Users\Admin\Desktop\test1.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                Console.WriteLine("enter some text");
                string s = Console.ReadLine();
                sw.WriteLine(s);
            }
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

        
       
        
    }
}
