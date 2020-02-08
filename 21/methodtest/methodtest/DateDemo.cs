using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodtest
{
    class DateDemo
    {
        public string Name { get; set; }
        public DateTime Dte { get; set; }

        public int GetAge()
        {
            TimeSpan age = DateTime.Today - Dte;
            Console.WriteLine("age{0}", age);
            double a = age.TotalDays / 365;
            return Convert.ToInt32(a);
        }
        public int GetMonth()
        {
            TimeSpan duration = DateTime.Today - Dte;
            double a = duration.TotalDays / 30;
            return Convert.ToInt32(a);
        }
        public string GetDate()
        {
            Console.WriteLine("enter no of days");
            int da = Convert.ToInt32(Console.ReadLine());
            DateTime dt = DateTime.Today.AddDays(da);
            DateTime dyt = DateTime.Today.AddYears(2);
            TimeSpan d = DateTime.Today.Subtract(dt);
            return string.Format("{0},{1},{2}", dt, dyt, d);

        }

    }
}
