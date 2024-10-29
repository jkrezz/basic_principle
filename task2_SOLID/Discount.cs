using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_SOLID
{
    internal abstract class Discount
    {
        public abstract double Calculate(double price);
    }
}
