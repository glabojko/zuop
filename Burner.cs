using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zuop
{
    public class Burner
    {
        double DailyBurningCapacity { get; set; }

        public Burner(double dailyBurningCapacity)
        {
            DailyBurningCapacity = dailyBurningCapacity;
        }

        public double GetCapacity()
        {
            return DailyBurningCapacity;
        }
    }
}
