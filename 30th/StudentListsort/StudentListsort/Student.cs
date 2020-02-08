using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListsort
{
    public class Student:IComparable<Student>
    {
        public string name;
        public int age;
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public int CompareTo(Student b)
        {
            // Alphabetic sort name[A to Z]
            return this.name.CompareTo(b.name);
        } 
    }
}
