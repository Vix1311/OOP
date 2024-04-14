using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Circle
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            this.Radius = radius;
        }

        public void Circumference()
        {
            Console.WriteLine("Circumference: {0}", this.Radius * 2 * Math.PI);
        }

        public void Area_of_a_circle()
        {
            Console.WriteLine("Area of a circle: {0}", Math.Pow(this.Radius * Math.PI, 2));
        }
    }
}
