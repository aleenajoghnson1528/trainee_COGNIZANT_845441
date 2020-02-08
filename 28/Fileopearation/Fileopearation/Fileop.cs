using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Fileopearation
{
    class Fileop
    {
        string path = @"C:\Users\Admin\Desktop\text2.txt";
        public void CreateFile()
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("enter your name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your city:");
                    string city = Console.ReadLine();
                    Console.WriteLine("enter your id: ");
                    string id = Console.ReadLine();
                    sw.WriteLine("my name is " + name);
                    sw.WriteLine("my city is " + city);
                    sw.WriteLine("my emp id is " + id);
                }
            }
        }

        public void Display()
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)


                {
                    Console.WriteLine(s);
                }
            }
        }
        public void AddFile()
        {
            string path = @"C:\Users\Admin\Desktop\text2.txt";
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
        public void Deleteelement()
        {
            File.Delete(path);
        }
    }
}















   