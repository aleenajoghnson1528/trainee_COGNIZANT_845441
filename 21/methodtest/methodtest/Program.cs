using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class Program
    {
        static void Main(string[] args)
        {
            //nostatic();
            // geTrObj(); 

            // geT2ndrobj();

            // geT3rdobj();  // now we can select which object should disply the data by commenting others

            // Objj1();

            // objj2();

            // objj3();

            //  objj4();

            //   Car c5 = new Car(); // this will show error if there is no default constructor in the Car.cs

            //  string data= c5.Showcar();
            // Console.WriteLine(data);

            //time();
            //  Automaticproperty();

            // studentobj();



            // measureob1();
            // vehicleobj();

            //  areaobj1();


            // sample();

            // NewMethod();

            //  aggregationexample();

            /*     Train tr = new Train();
                 tr.ShowTrain();
                 tr.Show();  

                 tr.Showvehicle(); */

            //  shipobj();


            // opearatoroveridinexample();



            // assesment();

            //  analystemployee();

            // Bank();

            // abstarctexample();
            // Hello h1 = new Hello(); // Cannot create an instance of the abstract class or interface 'Hello'	
            //  h1.Show();


            // interfaceexample1();
            //droneinterface();
            //  multipleinheritancusinginterface();

            //exceptionexample();


            //  helicopter();

            // abstarctexample2();


            TimeDate();
        /*    string data = "hello world";
            Console.WriteLine(data);
            string a = data.Insert(6, "my ");
            string bn = " you are so nice";
            Console.WriteLine(a);
            Console.WriteLine(string.Concat(a, bn));
            string up = data.ToUpper();
            string lp = up.ToLower();
            Console.WriteLine("{0} \t {1}", up, lp);


          Console.WriteLine("substring {0}", bn.Substring(4, 4));
            string[] names = new string[] { "aleena", "anand", "adarsh" };
            foreach (string st in names)
                {
                Console.WriteLine(st);
            }
            

            string allnames = string.Join(",", names);
            Console.WriteLine(allnames); 
            
            string st1 = "welcome to c#";
            string[] words = st1.Split();

            foreach(string s in words)
            {
                Console.WriteLine(s);
            }
            string nstr = string.Copy(st1);
            Console.WriteLine("copied string is{0}", nstr);
            
            int i = st1.IndexOf("to");
            Console.WriteLine("index of to is{0}", i);


            int l = st1.Length;
            Console.WriteLine("length is{0}", l);


            int nx = string.Compare("hello", "world");
            Console.WriteLine("comparison{0}", nx);
            int nx1 = string.Compare("hello", "hello");
            Console.WriteLine("comparison{0}", nx1);


            Array.Reverse(words);
            foreach(string w in words)
            {
                Console.WriteLine(w);
            }
            */

        }

        private static void TimeDate()
        {
            DateDemo g = new DateDemo { Name = "january", Dte = new DateTime(2019, 1, 24, 14, 0, 0) };
            Console.WriteLine($" this month is : {g.Name} \n today date: {g.Dte}");
            string dd = g.GetDate();
            Console.WriteLine("new date is {0}", dd);

            int d2 = g.GetMonth();
            Console.WriteLine("month is {0}", d2);


            int d3 = g.GetAge();
            Console.WriteLine("YEAR is{0}", d3);
        }

        private static void abstarctexample2()
        {
            Circle s1 = new Circle();
            double ans = s1.Area(3);
            Console.ReadLine();
        }

        private static void helicopter()
        {
            Helicopter h1 = new Helicopter();
            h1.Fly();
            Aeroplane a1 = new Aeroplane();
            a1.Fly();
        }

        private static void exceptionexample()
        {
            Divisionnew dd = new Divisionnew();

            double ans = dd.Divisiond(25, 0);
            Console.WriteLine(" result is{0} ", ans);
            Console.ReadKey();
        }

        private static void multipleinheritancusinginterface()
        {
            Calculation c11 = new Calculation();
            c11.add(12, 13);
            c11.sub(10, 2);
            c11.mul(2, 3);
            c11.div(4, 2);
            Console.WriteLine("Multiple Inheritance concept Using Interfaces :\n ");
            Console.WriteLine("Addition: " + c11.result1);
            Console.WriteLine("Substraction: " + c11.result2);
            Console.WriteLine("Multiplication :" + c11.result3);
            Console.WriteLine("Division: " + c11.result4);
            Console.ReadKey();
        }

        private static void droneinterface()
        {
            BikeDrone d1 = new BikeDrone();
            d1.display();
            d1.getfeature();
            Bike b1 = new Bike { Price = 10000, Model = 99 };
            Console.WriteLine($" price : {b1.Price} \n Model : {b1.Model}");
        }

        private static void interfaceexample1()
        {
            Doitnew a = new Doitnew();
            a.Getit();
            a.Gotit();
        }

        private static void abstarctexample()
        {
            Doit obj = new Doit();
            obj.Show();
        }

        private static void Bank()
        {
            Customer cu1 = new Customer { Cid = 123, Name = "aleena", Address = "xyz office", Ban = new BankAccount { Account_no = 35256, Balance = 346346 } };
            Console.WriteLine($" customer id : {cu1.Cid} \n name : {cu1.Name} \n address : {cu1.Address} \n account no :{cu1.Ban.Account_no}\n balance : {cu1.Ban.Balance}");

            FixedAccount fi = new FixedAccount();
            fi.InterestAmount(cu1.Ban.Balance);
        }
    }

     /*   private static void analystemployee()
        {
            Analyst al = new Analyst
            {
                EmpId = 323,
                Name = "aleena",
                Dept = new Department
                {
                    DeptId = 3,
                    DeptName = "xyz"
                }

            };


            Console.WriteLine("{0} \t {1}\t{2}\t {3} ", al.EmpId, al.Name, al.Dept.DeptId, al.Dept.DeptName);
            Console.WriteLine(al.EmpSalary(34000));
        }

        private static void assesment()
        {
            Productnew p1 = new Productnew { Pid = 123, Pname = "aleena", Price = 5000, Cat = new Category { Cid = 3, Description = "marketting" } };
            Console.WriteLine($" product id no : {p1.Pid} \n name : {p1.Pname} \n Price : {p1.Price} \n category id  :{p1.Cat.Cid}\n description: {p1.Cat.Description}");
        }

        private static void opearatoroveridinexample()
        {
            Demo d1 = new Demo(20, 50);
            d1.ShowData();

            Demo d2 = new Demo(240, 23);
            d2.ShowData();


            Demo s = new Demo();
            s = d1 + d2;
            s.ShowData();

            Demo d = new Demo();
            d = d1 - d2;
            d.ShowData();

            Demo d3 = new Demo();
            d3 = d1 * d2;
            d3.ShowData();
        }

        private static void aggregationexample()
        {
            Employee1 e1 = new Employee1 { Id = 123, Name = "aleena", Address = "xyz office", Dept = new Department1 { Dname = "production", Id = 3 } };
            Console.WriteLine($" emplyee no : {e1.Id} \n name : {e1.Name} \n address : {e1.Address} \n department name :{e1.Dept.Dname}\n department id : {e1.Dept.Id}");
        }

        private static void shipobj()
        {
            Ship sp = new Ship();
            sp.Showship();
            sp.Showvehicle();
        }

        private static void NewMethod()
        {
            Roadwayvehicle rv = new Roadwayvehicle();
            rv.Showvehicle();
            rv.Show();
        }

        private static void sample()
        {
            salesobj1();
            Sample sp = new Sample();
            Sample sp1 = new Sample();
            Sample sp2 = new Sample();
            Sample.show();
        }

        private static void salesobj1()
        {
            Sales s1 = new Sales(10, 34.2);
            Console.WriteLine(s1.display());

            Sales s2 = new Sales(12, 45.4);
            Console.WriteLine(s2.display());


            Sales.show();
            Sales.show1();
        }

        private static void nostatic()
        {
            Program pp = new Program();
            pp.nonstaticmethod();
        }

        public void nonstaticmethod()
        {
            Console.WriteLine("nonsttatic method");
        }




        private static void areaobj1()
        {
            Calculate cc1 = new Calculate();
            Console.WriteLine(cc1.area(23));

            Console.WriteLine(cc1.area(4, 5));
            Console.WriteLine(cc1.area(3.5));
            Console.WriteLine(cc1.area(3.2, 2));
        }

        private static void vehicleobj()
        {
            Vehicle v1 = new Vehicle { No = 345, Model = "suzhuki", Vtype = "98", Price = 45667047 };
            Console.WriteLine(" vehicle no : {0} \n model : {1} \n vehicle type : {2} \n price : {3}", v1.No, v1.Model, v1.Vtype, v1.Price);

            Vehicle v2 = new Vehicle { No = 678, Model = "alto", Vtype = "99", Price = 345098 };
            Console.WriteLine(" vehicle no : {0} \n model : {1} \n vehicle type : {2} \n price : {3}", v2.No, v2.Model, v2.Vtype, v2.Price);
        }

        private static void measureob1()
        {
            Scale s1 = new Scale();
            s1.Inch = 34;
            Console.WriteLine("inch is {0}", s1.Inch);
            s1.showmeasure();
        }



        private static void objj4()
              {
                  Car c4 = new Car("fgf7676", "maruthi", "red", 100000);
                  c4.Showcar();
              }

             private static void objj3()
              {
                  Car c3 = new Car("3565", "suzuki");
                  c3.Showcar();
              }

              private static void objj2()
              {
                  Car c2 = new Car("1234");
                  c2.Showcar();
              }

              private static void Objj1()
              {
                  Car c1 = new Car();
                  Console.WriteLine();
                  c1.Showcar();
              }

              private static void geT3rdobj()
              {
                  Trainee tr2 = new Trainee();
                  tr2.Getdata("divya", "Emp2345", "kerala", 21);
                  tr2.age = 12; //all instance variable should private. otherwise we can access by it using object
                  tr2.ShowData();
              }

             private static void geT2ndrobj()
              {
                  Trainee tr1 = new Trainee();
                  Console.WriteLine();
                  tr1.Getdata("afsana", "emp845400", "kerala", 21);
                  tr1.ShowData();
              }

              private static void geTrObj()
              {
                  //object of trainee class
                  Trainee tr = new Trainee();
                  tr.Getdata("aleena", "emp845441", "kerala", 21);
                  tr.ShowData();
              } 
        
        private static void studentobj()
        {
            //  Student std = new Student();
            Student std = new Student("aleena", "johnson");
            // std.Name = "aleena";
            std.Idno = 123;
            std.Course = "c#";


            //  std.Joindate = DateTime.Parse("01-01-2019");
            std.Joindate = Convert.ToDateTime("01-01-2019");  // another statement for above statement


            Console.WriteLine("name is {0} \n id is {1} \n ", std.Name, std.Idno);
            Console.WriteLine("course is {0} \n joining date is {1} \n ", std.Course, std.Joindate.ToShortDateString());
        }

        private static void Automaticproperty()
        {
            Product pd = new Product { Id = 1, Pname = "cholcate", Price = 100 };  // autoMATIC PROPERTY NO CONSTRUCTORS
            Console.WriteLine("PRODUCT ID : {0} \n PRODUCT NAME : {1} \n PRICE :{2} ", pd.Id, pd.Pname, pd.Price);
        }

         private static void time()
         {
             Timeperiod t1 = new Timeperiod();
             t1.Hours = 19;
             Console.WriteLine(" hours {0} ", t1.Hours);
             t1.showseconds();
         } 
    }*/
}