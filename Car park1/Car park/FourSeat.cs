using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_park
{
    public class FourSeat : Vehical
    {
        public int Price { get; set; }
        public FourSeat(string id, DateTime timeIn, CarType fourseat) : base(id, timeIn)
        {
        }
        public FourSeat() { }
    }
}
