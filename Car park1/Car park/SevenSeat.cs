using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_park
{
    public class SevenSeat : Vehical
    {
        public int Price { get; set; }
        public SevenSeat(string id, DateTime timeIn, CarType sevenseat) : base(id, timeIn)
        {
        }
        public SevenSeat() { }
    }
}

