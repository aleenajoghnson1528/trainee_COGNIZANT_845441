using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace greet
{
    class Program
    {


        static void Main(string[] args)
        {
            int age;
            string name;
            Console.WriteLine("enter age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine(greetings(age, name));
        }
        public static string greetings(int age, string name)
        {

            string res = " congrats " + name + " on your " + age + "nd birthday ";
            return res;

        }
       

    }
}
