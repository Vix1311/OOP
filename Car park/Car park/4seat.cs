using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_park
{
    public class _4seat : Car, IBill
    {
        public int Price { get; set; }
        public _4seat(int id, int day_in, int day_out)
        {
        }

        public _4seat()
        {
        }

        public override void CarInfo()
        {
            Console.WriteLine("Car Id: {0}", this.Id);
            Console.WriteLine("Day car in: {0}", this.DayIn);
            Console.WriteLine("Day car out: {0}", this.DayOut);

        }
        public override void Bill()
        {
            Console.WriteLine("Bill: {0}", (10 * (this.DayOut - this.DayIn)));
        }

        public void PrintTypes(Car a)
        {
            Console.WriteLine(a.GetType() == typeof(Car)); // false 
            Console.WriteLine(a is Car);                   // true 
            Console.WriteLine(a.GetType() == typeof(_4seat));    // true
            Console.WriteLine(a is _4seat);                      // true 
        }
      
    }
}
