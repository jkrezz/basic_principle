using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Car : Vehicle
    {
        public string _carModel { get; set; }

        public Car(int maxSpeed, string color, string model)
            : base(maxSpeed, color)
        {
            _carModel = model;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Car type is: {_carModel}\n");
        }
    }
}
