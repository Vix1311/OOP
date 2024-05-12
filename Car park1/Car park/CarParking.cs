using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_park
{
    public class CarParking
    {
        public List<Vehical> Vehicals { get; set; } = new List<Vehical>();
        public CarParking()
        {
        }
        public int CountCarType(CarType cartype)
        {
            switch (cartype)
            {
                case CarType.FourSeat:
                    return Vehicals.Count(x => x.GetType() == typeof(FourSeat));
                case CarType.SevenSeat:
                    return Vehicals.Count(x => x.GetType() == typeof(SevenSeat));
                default:
                    return Vehicals.Count(x => x.GetType() == typeof(Truck));
            }
        }
    }
}


