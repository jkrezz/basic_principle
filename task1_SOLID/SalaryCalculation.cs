using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_SOLID
{
    internal class SalaryCalculation
    {
        public double CalculateSalary(Employee employee)
        {
            return employee._salary - employee._fine;
        }
    }
}
