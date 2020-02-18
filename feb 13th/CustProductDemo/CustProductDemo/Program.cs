using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustProductDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // insert();
            display();

        }

        private static void display()
        {
            ContextClass ctx = new ContextClass();
            Console.WriteLine("\ncustomers...................");
            var customers = ctx.Customers;
            foreach (var cst in customers)
            {
                Console.WriteLine("{0}\t{1}\t{2}", cst.Cid, cst.Cname, cst.Caddress);
            }
            Console.WriteLine("\nproducts...................");
            var products = ctx.Products;
            foreach (var prd in products)
            {
                Console.WriteLine("{0}\t{1}\t{2}", prd.Pid, prd.Pname, prd.Price);
            }
            Console.WriteLine("\npurchases...................");
            var purchases = ctx.Purchases;
            foreach (var pr in purchases)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}", pr.Id, pr.OrderDate, pr.Pid, pr.Cid, pr.Product.Pname, pr.Product.Price, pr.Customer.Cname, pr.Customer.Caddress);
            }
        }

        private static void insert()
        {
            ContextClass ctx = new ContextClass();
               var customers = new List<Customer>
               {

                   new Customer { Cname = "aleena" ,Caddress="chennai"},
                 new Customer { Cname = "johnson", Caddress = "hyderabad" },
               new Customer { Cname = "anand", Caddress = "kochi" },
               new Customer { Cname = "adarsh", Caddress = "kottayam" },
               new Customer { Cname = "lovely", Caddress = "chennai" },
               new Customer { Cname = "molly", Caddress = "alapuzha" }
                };
               customers.ForEach(s => ctx.Customers.Add(s));
               ctx.SaveChanges();  

               var products = new List<Product>
               {

                    new Product {Pname="Rice",Price=45},
                     new Product {Pname="dal",Price=48},
                      new Product {Pname="detegent",Price=50},
                       new Product {Pname="soap",Price=30},

                    new Product {Pname="vermicelly",Price=35},
                     new Product {Pname="sweets",Price=50},
                      new Product {Pname="snacks",Price=15},

               };
               products.ForEach(p => ctx.Products.Add(p));
               ctx.SaveChanges();
            var purchase = new List<Purchase>
               {

                    new Purchase {OrderDate=Convert.ToDateTime("02-09-2020"),Pid=1,Cid=2},
                      new Purchase {OrderDate=Convert.ToDateTime("02-09-2020"),Pid=2,Cid=1},
                        new Purchase {OrderDate=Convert.ToDateTime("02-09-2020"),Pid=3,Cid=2},

                    new Purchase {OrderDate=Convert.ToDateTime("02-09-2020"),Pid=3,Cid=3},
                      new Purchase {OrderDate=Convert.ToDateTime("02-09-2020"),Pid=4,Cid=4},
                        new Purchase {OrderDate=Convert.ToDateTime("02-09-2020"),Pid=5,Cid=2},


               };
            purchase.ForEach(pr => ctx.Purchases.Add(pr));
            ctx.SaveChanges();

        }
    }
}
