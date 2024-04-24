using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_park
{
    public abstract class Car
    {
        public int Id {  get; set; }
        public int DayIn {  get; set; }
        public int DayOut { get; set; }
        public Car() { }
  
        public abstract void CarInfo();
        public abstract void Bill();
        public void Inputinformation()
        {
            Console.WriteLine("Please input Id:");
            var Id = Console.ReadLine();
            var intId = Int32.Parse(Id);
            Console.WriteLine("Please input day in:");
            var DayIn = Console.ReadLine();
            var intday_in = Int32.Parse(DayIn);
            Console.WriteLine("Please input day out:");
            var DayOut = Console.ReadLine();
            var intday_out = Int32.Parse(DayOut);
            this.Id = intId;
            this.DayIn = intday_in;
            this.DayOut = intday_out;
        }
      

    }
}


