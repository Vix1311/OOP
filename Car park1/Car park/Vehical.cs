using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_park
{
    public abstract class Vehical
    {
        public string Id { get; set; } = default!;
        public DateTime TimeIn { get; set; }
        public Vehical(string id, DateTime timeIn)
        {
            this.Id = id;
            this.TimeIn = timeIn;
        }
        public Vehical() { }    
    }
}
