using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Vehicle
    {
        public int _maxSpeed;
        public string _color;

        public Vehicle(int speed, string color)
        {
            _maxSpeed = speed;
            _color = color;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"MaxSpeed: {_maxSpeed} km/h, Color: {_color}");
        }
    }
}
