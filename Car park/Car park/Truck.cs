using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_park
{
    public class Truck:Car,IBill
    {
            public int Price { get; set; }
            public Truck(int id, int day_in, int day_out, int price) 
            {
            }
            public Truck() { }
            public override void CarInfo()
            {
                Console.WriteLine("Car Id: {0}", this.Id);
                Console.WriteLine("Day car in: {0}", this.DayIn);
                Console.WriteLine("Day car out: {0}", this.DayOut);

            }
            public override void Bill()
            {
                Console.WriteLine("Bill: {0}", (20 * (this.DayOut - this.DayIn)));
            }
        }
    }

