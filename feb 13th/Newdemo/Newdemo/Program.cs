using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            addproduct();
            // selectcustomer();

           // display();

        }

        private static void display()
        {
            int i = 1;
            Contextclass obj = new Contextclass();
            Console.WriteLine("enter name:");
            string name = Console.ReadLine();
            List<Product> p = new List<Product>();
            //obj.Products.Add(new Product { Pname = 12, Price = 25 });
            while (i != 0)
            {

                Console.WriteLine("product name:");
                string namep = Console.ReadLine();
                Console.WriteLine("Enter price");
                double price = Convert.ToDouble(Console.ReadLine());
                p.Add(new Product { Pname = namep, Price = price });
                Console.WriteLine("need more product: Y/N");
                char opt = char.Parse(Console.ReadLine());
                if (opt == 'n' || opt == 'N')
                {
                    i = 0;
                }
            }
            obj.Customer.Add(new Customer
            {
                Cname = name,
                Pidd = p
            });
            obj.SaveChanges();


            var e = obj.Customer;
            var pt = obj.Product;
            var query = (from cust in e
                         join pro in pt
          on cust.Cid equals pro.Cid

                         select new
                         {
                             cust.Cid,
                             cust.Cname,
                             pro.Pname,
                             pro.Price
                         });
            Console.WriteLine("Enter customer id:");
            int id1 = int.Parse(Console.ReadLine());
            var getn = from a in query
                       where a.Cid == id1
                       select a;
            foreach (var m in getn)
            {
                Console.WriteLine("{0}\t{1}\t{2}", m.Cname, m.Pname, m.Price);
            }
        }

        private static void selectcustomer()
        {
            Contextclass c1 = new Contextclass();
            var pro = c1.Customer;
            Console.WriteLine("Enter Customer id:");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach (var a in pro)
            {
                if (id == a.Cid)
                {
                    Console.WriteLine("{0}\t{1}", a.Cid, a.Cname);
                }

            }
        }

        private static void addproduct()
        {
            int i = 1;
            Contextclass obj = new Contextclass();
            Console.WriteLine("enter name:");
            string name = Console.ReadLine();
            List<Product> p = new List<Product>();
            //obj.Products.Add(new Product { Pname = 12, Price = 25 });
            while (i != 0)
            {

                Console.WriteLine("product name:");
                string namep = Console.ReadLine();
                Console.WriteLine("Enter price");
                double price = Convert.ToDouble(Console.ReadLine());
                p.Add(new Product { Pname = namep, Price = price });
                Console.WriteLine("need more product: Y/N");
                char opt = char.Parse(Console.ReadLine());
                if (opt == 'n' || opt == 'N')
                {
                    i = 0;
                }
            }
            obj.Customer.Add(new Customer
            {
                Cname = name,
                Pidd = p
            });
            obj.SaveChanges();
        }
    }
    
}
