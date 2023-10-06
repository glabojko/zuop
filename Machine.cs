using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zuop
{
    public class Machine
    {
        public double DailyCapacity { get; set; }

        public Machine(double dailyCapacity)
        {
            DailyCapacity = dailyCapacity;
        }
        public double GetCapacity()
        {
            return DailyCapacity;
        }
    }
}
