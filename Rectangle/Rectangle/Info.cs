using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    public class Info
    {
        public int Length { get; set; }
        public int Width { get; set; }
    
        public Info(int length, int width)
        {
            this.Length = length;
            this.Width = width; 
        }
        public void Perimeter_of_a_rectangle()
        {
            Console.WriteLine("perimeter of a rectangle: {0}", (this.Length + this.Width) * 2);
        }
        public void Area_of_a_ractangle()
        {
        Console.WriteLine("Area_of_a_ractangle: {0}", this.Length * this.Width);
        }
    }
}
