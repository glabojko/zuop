using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zuop
{
    internal class Shredder
    {
        double DailyShreddingCapacity { get; set; }

        public Shredder(double dailyShreddingCapacity)
        {
            DailyShreddingCapacity = dailyShreddingCapacity;
        }

        public double GetCapacity()
        {
            return DailyShreddingCapacity;
        }
    }
}
