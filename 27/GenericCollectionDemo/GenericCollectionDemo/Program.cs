using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // queueexample();

            // stackexample();

            // hashsetexample();

            //  listexample();


            // dicexample();


             sortdicexample();



           // dicexample1();

        }

        private static void dicexample1()
        {
            Dictionary<int, Course> dcrs = new Dictionary<int, Course>();
            dcrs.Add(1, new Course
            {
                Cid = 100,
                Cname = "c#",
                StartDate = DateTime.Today,
                Fee = 6000
            });
            dcrs.Add(2, new Course
            {
                Cid = 200,
                Cname = "python",
                StartDate = DateTime.Today,
                Fee = 7000
            });
            dcrs.Add(3, new Course
            {
                Cid = 300,
                Cname = "html",
                StartDate = DateTime.Today,
                Fee = 7000
            });

            foreach (KeyValuePair<int, Course> dc in dcrs)
            {
                Console.WriteLine("{0}\t {1}\t{2}\t{3}\t{4}", dc.Key, dc.Value.Cid, dc.Value.Cname, dc.Value.StartDate.ToShortDateString(),
                    dc.Value.Fee);
            }
        }

        private static void sortdicexample()
        {
            SortedDictionary<int, string> sortdt = new SortedDictionary<int, string>();
            sortdt.Add(123, "chennai");
            sortdt.Add(214, "hydrabad");
            sortdt.Add(654, "kolkatha");
            foreach (KeyValuePair<int, string> ct in sortdt)
            {
                Console.WriteLine("{0}\t{1}",ct.Key, ct.Value);
            }
        }


              private static void listexample()
                 {
                     List<Course> courselist = new List<Course>();
                     courselist.Add(new Course
                     {
                         Cid = 1,
                         Cname = "c#",
                         StartDate = DateTime.Today,
                         Fee = 6000
                     });

                     courselist.Add(new Course
                     {
                         Cid = 2,
                         Cname = "webpages",
                         StartDate = DateTime.Parse("05-02-2020"),
                         Fee = 5000
                     });
                     courselist.Add(new Course
                     {
                         Cid = 3,
                         Cname = "python",
                         StartDate = Convert.ToDateTime("08-02-2020"),
                         Fee = 7000
                     });
                     foreach (Course cr in courselist)
                     {
                         Console.WriteLine("\0 \t {1} \t {2}\t{3}", cr.Cid, cr.Cname, cr.StartDate, cr.Fee);
                     }

                 }

                 private static void hashsetexample()
                 {
                     HashSet<Course> hset = new HashSet<Course>();  //in generic there is no hash table. only hashset. for hash set use collections
                     hset.Add(new Course
                     {
                         Cname = "bootstrap",
                         Cid = 1,

                         StartDate = DateTime.Today,
                         Fee = 6000
                     });
                     hset.Add(new Course
                     {
                         Cname = "javascript",
                         Cid = 2,

                         StartDate = Convert.ToDateTime("04-04-2020"),
                         Fee = 6000
                     });
                     foreach (Course cr in hset)
                     {
                         Console.WriteLine("{0}\t {1}\t{2}\t{3}", cr.Cname, cr.Cid, cr.StartDate, cr.Fee);
                     }
                 }

                 private static void stackexample()
                 {
                     Stack<Course> stcr = new Stack<Course>();
                     stcr.Push(new Course
                     {
                         Cname = "bootstrap",
                         Cid = 1,

                         StartDate = DateTime.Today,
                         Fee = 6000
                     });

                     stcr.Push(new Course
                     {
                         Cname = "php",
                         Cid = 2,

                         StartDate = Convert.ToDateTime("04-04-2020"),
                         Fee = 70000
                     });

                     stcr.Push(new Course
                     {
                         Cname = "html",
                         Cid = 3,

                         StartDate = Convert.ToDateTime("05-06-2020"),
                         Fee = 70000
                     });
                     foreach (Course cr in stcr)
                     {
                         Console.WriteLine("{0}\t {1}\t{2}\t{3}", cr.Cname, cr.Cid, cr.StartDate, cr.Fee);
                     }
                 }

                 private static void queueexample()
                 {
                     Queue<Course> qcrs = new Queue<Course>();

                     qcrs.Enqueue(new Course
                     {

                         Cname = "bootstrap",
                         Cid = 1,

                         StartDate = DateTime.Today,
                         Fee = 6000
                     });

                     qcrs.Enqueue(new Course
                     {
                         Cname = "php",
                         Cid = 2,

                         StartDate = Convert.ToDateTime("04-04-2020"),
                         Fee = 70000
                     });

                     qcrs.Enqueue(new Course
                     {
                         Cname = "html",
                         Cid = 3,

                         StartDate = Convert.ToDateTime("05-06-2020"),
                         Fee = 70000
                     });
                     foreach (Course cr in qcrs)
                     {
                         Console.WriteLine("{0}\t {1}\t{2}\t{3}", cr.Cname, cr.Cid, cr.StartDate, cr.Fee);
                     }
                 }  
         }

       
    }
    
