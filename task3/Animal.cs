using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Animal
    {
        public string _name { get; set; }

        public Animal(string name)
        {
            _name = name;
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Any animal sound");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {_name}");
        }
    }
}
