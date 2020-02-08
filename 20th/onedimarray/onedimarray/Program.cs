using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onedimarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] marks = new int[6];
            Console.WriteLine("Enter your mark of 6 subjects:");
            for (int i = 0; i < marks.Length; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
                for (int i = 0; i < marks.Length; i++)
                {
                    Console.WriteLine("subject no {0} ={1}", i + 1, marks[i]);
                }
            Console.ReadKey();
        }
    }
}
