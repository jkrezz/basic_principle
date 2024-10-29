using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_SOLID
{
    internal class Employee
    {
        public string _name { get; set; }
        public string _position { get; set; }
        public double _salary { get; set; }
        public double _fine { get; set; }

        public Employee(string name, string position, double salary, double fine)
        {
            _name = name;
            _position = position;
            _salary = salary;
            _fine = fine;
        }
    }
}
