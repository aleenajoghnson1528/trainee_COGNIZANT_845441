using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryExample
{
    public class Calculation
    {
        public int NO1 { get; set; }
        public int NO2 { get; set; }
        public string Add()
        {
            return string.Format("sum={0}", NO1 + NO2);
                
        }
        public string Difference()
        {
            return string.Format("Difference={0}", NO1 - NO2);
        }
        public string Multiply()
        {
            return string.Format("Product={0}", NO1 * NO2);
        }
        public string Division()
        {
            return string.Format("division result={0}", NO1 / NO2);
        }
    }
}
