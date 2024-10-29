using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Bicycle : Vehicle
    {
        public string _bicycleType { get; set; }

        public Bicycle(int maxSpeed, string color, string type)
            : base(maxSpeed, color)
        {
            _bicycleType = type;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Bicycle type is {_bicycleType}\n");
        }
    }
}
