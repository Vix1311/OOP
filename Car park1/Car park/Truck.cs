using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_park
{
    public class Truck : Vehical
    {
        public int Price { get; set; }
        public Truck(string id, DateTime timeIn, CarType truck) : base(id, timeIn)
        {
        }
        public Truck() { }  
    }

}

