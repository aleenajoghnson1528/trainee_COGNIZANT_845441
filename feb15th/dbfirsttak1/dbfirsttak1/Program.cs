using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbfirsttak1
{
    class Program
    {
        static productDBEntities pdb = new productDBEntities();
        static void Main(string[] args)
        {
            //insertcategory();
             // insertproduct();

          //  selectcategories();

           // selectproducts();

        }

        private static void selectproducts()
        {
            Console.WriteLine("all available products...");
            var products = pdb.products;
            foreach (var p in products)
            {
                Console.WriteLine("{0,5}\t{1,5}\t{2,5}\t{3,5}", p.Pid, p.price, p.Title, p.Cid);

            }
        }

        private static void selectcategories()
        {
            Console.WriteLine("all available categories....");
            var categories = pdb.Categories;
            foreach (var c in categories)
            {
                Console.WriteLine("{0}\t{1}", c.Cid, c.Cname);

            }
        }

        private static void insertproduct()
        {
            int i = 1;
            while (i !=0)
            {
                Console.WriteLine("enter product id:");
                int pid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("enter category id:");
                int cid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter product name");
                string title = Console.ReadLine();
                Console.WriteLine("Enter price");
                double price = Convert.ToDouble(Console.ReadLine());
                var productnew = new product
                {
                    Pid = pid,
                    Cid = cid,
                    Title = title,
                    price = price


                };
                Console.WriteLine("need new product...? y/n");
                char result = char.Parse(Console.ReadLine());
                if (result =='N' || result=='n')
                {
                    i = 0;
                }

                pdb.products.Add(productnew);
                pdb.SaveChanges();
              
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
                    Cname = cname

                };
                Console.WriteLine("need more categories...? y/n");
                char result = char.Parse(Console.ReadLine());
                if (result == 'N' || result == 'n')
                {
                    i = 0;
                }
                pdb.Categories.Add(categorynew);
                pdb.SaveChanges();
            }
        }
    }
}
