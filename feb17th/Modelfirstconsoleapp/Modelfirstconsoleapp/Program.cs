using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelfirstconsoleapp
{
    class Program
    {
        static modelfirstentityContainer mf = new modelfirstentityContainer();
        static void Main(string[] args)
        {
            //  insertproduct();

            //insertcategory();


            // displayproducts();
            //   displaycategories();
            // updateproduct();
           selectonecategory();
        }

        private static void selectonecategory()
        {
            var product = mf.Products;
            Console.WriteLine("enter category id:");
            int id = Convert.ToInt32(Console.ReadLine());
            var query = from aq in product
                        where aq.Cid == id
                        select aq;

            mf.SaveChanges();
            foreach (var p in query)
            {

                Console.WriteLine("{0}\t{1}\t{2}\t{3}", p.Id, p.Price, p.Ptitle, p.Cid);

            }
        }

        private static void updateproduct()
        {
            var products = mf.Products;
            Console.WriteLine("Enter product id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter new price:");
            double price = Convert.ToDouble(Console.ReadLine());

            var query = from aq in products
                        where aq.Id == id
                        select aq;

            foreach (var e in query)
            {
                e.Price = price;
            }
            mf.SaveChanges();
            foreach (var p in query)
            {

                Console.WriteLine("{0}\t{1}\t{2}\t{3}", p.Id, p.Price, p.Ptitle, p.Cid);

            }
        }

        private static void displaycategories()
        {
            Console.WriteLine("display all categories....");
            var cat = mf.Categories;
            foreach (var c in cat)
            {
                Console.WriteLine("{0}\t{1}", c.Cid, c.Ctitle);
            }
        }

        private static void displayproducts()
        {
            Console.WriteLine("display all products......");
            var products = mf.Products;
            foreach (var p in products)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", p.Id, p.Price, p.Ptitle, p.Cid);
            }
        }

        private static void insertcategory()
        {
            int i = 1;
            while (i != 0)
            {


                Console.WriteLine("Enter category id");
                int cid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter category name");
                string cname = Console.ReadLine();

                var categorynew = new Category
                {
                    Cid = cid,
                    Ctitle = cname

                };
                Console.WriteLine("need more categories...? y/n");
                char result = char.Parse(Console.ReadLine());
                if (result == 'N' || result == 'n')
                {
                    i = 0;
                }
                mf.Categories.Add(categorynew);
                mf.SaveChanges();
            }
        }

        private static void insertproduct()
        {

            int i = 1;
            while (i != 0)
            {
               
                Console.WriteLine("Enter product name:");
                string pname = Console.ReadLine();
                Console.WriteLine("Enter price");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter category id:");
                int cid = Convert.ToInt32(Console.ReadLine());

                var product = new Product
                {
                   
                    Ptitle = pname,
                    Price = price,
                    Cid = cid
                };
                Console.WriteLine("need more categories...? y/n");
                char result = char.Parse(Console.ReadLine());
                if (result == 'N' || result == 'n')
                {
                    i = 0;
                }
                mf.Products.Add(product);
                mf.SaveChanges();
            }


        }
    }

}
