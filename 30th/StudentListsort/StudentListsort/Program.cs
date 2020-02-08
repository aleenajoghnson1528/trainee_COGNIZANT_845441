using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListsort
{
    class Program
    {

        public static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            students.Add(new Student("johnson", 22));
            students.Add(new Student("aleena", 25));
            students.Add(new Student("lovely", 27));


            students.Sort();
            foreach (Student n in students)
            {
                Console.WriteLine(n.name);
            }


            Console.ReadLine();
        }
    }
}
