using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avg
{
    class Program
    {

        public static double getavg(int[] marks)
        {
            double avg, sum = 0;
            int i;
            for(i=0;i<marks.Length;i++)
            {
                sum = sum + marks[i];
            }
            avg = sum / i;
            return (avg);
        }



        static void Main(string[] args)
        {
            int[] marks = new int[6];
            Console.WriteLine("Enter mark of 6 subjects");
            for(int i=0;i<marks.Length;i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
            double avg = getavg(marks);
            for(int i =0; i<marks.Length;i++)
            {
                Console. WriteLine("Subject no {0} ={1}", i + 1, marks[i]);
            }
            Console.WriteLine("average mark is {0}", avg);
            Console.ReadKey();
        }
    }
}
