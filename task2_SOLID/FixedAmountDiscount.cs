using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_SOLID
{
    internal class FixedAmountDiscount : Discount
    {
        private double _amount;

        public FixedAmountDiscount(double amount)
        {
            _amount = amount;
        }

        public override double Calculate(double price)
        {
            return price - _amount;
        }
    }
}
