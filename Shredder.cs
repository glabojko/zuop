using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zuop
{
    internal class Shredder
    {
        double DailyCapacity { get; set; }

        public Shredder(double dailyCapacity)
        {
            DailyCapacity = dailyCapacity;
        }

        public double GetCapacity()
        {
            return DailyCapacity;
        }
    }
}
