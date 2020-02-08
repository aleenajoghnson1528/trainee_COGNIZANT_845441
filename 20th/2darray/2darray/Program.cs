using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2darray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mat = new int[3, 3];
            Console.WriteLine("Enter the elements");
            for (int i= 0; i < 3; i++)
            {
                for(int j=0; j < 3; j++)
                {
                    mat[i, j] = int.Parse(Console.ReadLine());
                }
            }
           

            for(int i=0; i < 3; i++)
            {
                for(int j=0; j < 3; j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
