using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_park
{
    public abstract class Car
    {
        public int Id { get; set; }
        public int DayIn { get; set; }
        public int DayOut { get; set; }
        public Car() { }

        public abstract void CarInfo();
        public abstract void Bill();
        public abstract void Inputinformation();



    }
}
