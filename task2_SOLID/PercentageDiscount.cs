using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_SOLID
{
    internal class PercentageDiscount : Discount
    {
        private double _percentage;

        public PercentageDiscount(double percentage)
        {
            _percentage = percentage;
        }

        public override double Calculate(double price)
        {
            return price * (1 - (_percentage / 100));
        }
    }
}
