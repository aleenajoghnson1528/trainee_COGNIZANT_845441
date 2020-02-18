using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookapp
{
    class Program
    {
        static void Main(string[] args)
        {
            // inserdata();
            ContextClass ctx = new ContextClass();
                Console.WriteLine("\nAuthors......................");
            var author = ctx.Authores;
            foreach(var a in author)
            {
                Console.WriteLine("{0}\t{1}\t{2}", a.Aid, a.Aname, a.Address);

            }

            Console.WriteLine("\nBooks................");
            var book = ctx.Books;
            foreach(var b in book)
            {
                Console.WriteLine("{0}\t{1}\t{2}", b.Bid, b.Title, b.Price);
            }

            Console.WriteLine("\ndetails....................");
            var det = ctx.Details;
            foreach(var d in det)
            {
                Console.WriteLine("{0,-5}\t{1,-5}\t{2,-5}\t{3,-5}\t{4,-5}\t{5,-5}\t{6,-5}\t{7,-5}", d.OrderDate, d.Id, d.Bid, d.Aid, d.Authors.Aname, d.Authors.Address, d.Books.Price, d.Books.Title);
            }

        }

        private static void inserdata()
        {
            ContextClass ctx = new ContextClass();
            var books = new List<Book>
            {
                new Book {Title="road not taken",Price=500},

                new Book {Title="my life story",Price=250},

                new Book {Title="dark night",Price=350},
                  new Book {Title="i promise ria",Price=450},

                new Book {Title="call center",Price=350},
                  new Book {Title="late night tales",Price=450},

            };
            books.ForEach(b => ctx.Books.Add(b));
            ctx.SaveChanges();

            var authors = new List<Author>
            {
                new Author {Aname="aleena", Address="Chennai"},
                  new Author {Aname="anand", Address="kochi"},
                    new Author {Aname="adarsh", Address="hydrabad"},
                      new Author {Aname="johnson", Address="kottayam"},
                        new Author {Aname="lovely", Address="kochi"},
            };
            authors.ForEach(a => ctx.Authores.Add(a));
            ctx.SaveChanges();

            var detail = new List<Detail>
               {

                    new Detail {OrderDate=Convert.ToDateTime("02-09-2020"),Bid=1,Aid=2},
                      new Detail {OrderDate=Convert.ToDateTime("02-09-2020"),Bid=2,Aid=1},
                        new Detail {OrderDate=Convert.ToDateTime("02-09-2020"),Bid=3,Aid=3},
                          new Detail {OrderDate=Convert.ToDateTime("02-09-2020"),Bid=4,Aid=5},
                            new Detail {OrderDate=Convert.ToDateTime("02-09-2020"),Bid=5,Aid=4},
                              new Detail {OrderDate=Convert.ToDateTime("02-09-2020"),Bid=6,Aid=2},

                              new Detail {OrderDate=Convert.ToDateTime("02-09-2020"),Bid=1,Aid=1},


               };
            detail.ForEach(pr => ctx.Details.Add(pr));
            ctx.SaveChanges();
        }
    }
}
