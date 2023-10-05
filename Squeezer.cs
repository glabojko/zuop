using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zuop
{
    public class Squeezer
    {
        double DailySqueezingCapacity { get; set; }

        public Squeezer(double dailySqueezingCapacity)
        {
            DailySqueezingCapacity = dailySqueezingCapacity;
        }

        public double GetCapacity()
        {
            return DailySqueezingCapacity;
        }
    }
}
