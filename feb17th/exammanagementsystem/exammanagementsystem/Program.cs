using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exammanagementsystem
{
    class Program
    {
        static modelfirstentityoneContainer mf = new modelfirstentityoneContainer();
        static void Main(string[] args)
        {
             inserttostudent();
           inserttocourse();

            insertintoschool();

            inserttoexam();


             selectallstudents();
             selectallschools();

            listofcourse();



            selectexamlist();

        }

        private static void selectexamlist()
        {
            Console.WriteLine("list of exams....");
            var exam = mf.Exams;
            foreach (var e in exam)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", e.Eid, e.Ename, e.Place, e.Course_id, e.Exam_date, e.Sid);
            }
        }

        private static void listofcourse()
        {
            Console.WriteLine("list of courses....");
            var course = mf.Course_offering;
            foreach (var s in course)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", s.Course_id, s.semester, s.year, s.room, s.Cname);
            }
        }

        private static void selectallschools()
        {
            Console.WriteLine("list of schools....");
            var school = mf.Schools;
            foreach (var s in school)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t", s.School_id, s.School_name, s.address);
            }
        }

        private static void selectallstudents()
        {
            Console.WriteLine("all available students....");
            var student = mf.Students;
            foreach (var s in student)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t", s.Sid, s.school_id, s.Sname, s.Course_id);

            }
        }

        private static void inserttoexam()
        {
           

                Console.WriteLine("enter exam name");
                string ename = Console.ReadLine();
                Console.WriteLine("enter exam place");
                string eplace = Console.ReadLine();
                Console.WriteLine("enter course id");
                int cid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter exam date");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("enter student id");
                int sid = Convert.ToInt32(Console.ReadLine());


                var examnew = new Exam
                {
                    Ename = ename,
                    Place = eplace,
                    Course_id = cid,
                    Exam_date = date,
                    Sid = sid

                };
              /*  Console.WriteLine("need more exam details... y/n");
                char result = char.Parse(Console.ReadLine());
                if (result == 'N' || result == 'n')
                {
                    i = 0;
                }  */
                mf.Exams.Add(examnew);
                mf.SaveChanges();

            
        }

        private static void insertintoschool()
        {
            int i = 1;
            while (i != 0)
            {
                Console.WriteLine("Enter school name");
                string sname = Console.ReadLine();
                Console.WriteLine("Enter school address");
                string saddress = Console.ReadLine();



                var schoolnew = new School
                {
                    School_name = sname,
                    address = saddress
                };
                Console.WriteLine("need more students... y/n");
                char result = char.Parse(Console.ReadLine());
                if (result == 'N' || result == 'n')
                {
                    i = 0;
                }
                mf.Schools.Add(schoolnew);
                mf.SaveChanges();

            }
        }

        private static void inserttocourse()
        {
            int i = 1;
            while (i != 0)
            {
                Console.WriteLine("Enter semester");
                int semester = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter year");
                DateTime date = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("enter your room");
                int roomno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter your course name");
                string cname = Console.ReadLine();

                var coursenew = new Course_offering
                {
                    semester = semester,
                    year = date,
                    room = roomno,
                    Cname = cname
                };
                Console.WriteLine("need more students... y/n");
                char result = char.Parse(Console.ReadLine());
                if (result == 'N' || result == 'n')
                {
                    i = 0;
                }
                mf.Course_offering.Add(coursenew);
                mf.SaveChanges();

            }
        }

        private static void inserttostudent()
        {
            int i = 1;
            while (i != 0)
            {
                Console.WriteLine("Enter student name");
                string sname = Console.ReadLine();
                Console.WriteLine("enter school id");
                int school_id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter course id");
                int course_id = Convert.ToInt32(Console.ReadLine());

                var studentnew = new Student
                {
                    Sname = sname,
                    school_id = school_id,
                    Course_id = course_id
                };
                Console.WriteLine("need more students... y/n");
                char result = char.Parse(Console.ReadLine());
                if (result == 'N' || result == 'n')
                {
                    i = 0;
                }
                mf.Students.Add(studentnew);
                mf.SaveChanges();

            }
        }
    }
}
