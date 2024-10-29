using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_SOLID
{
    internal class Sparrow : Bird, IFlyable
    {
        public override void Say()
        {
            Console.WriteLine("Sparrow says...");
        }

        public void Fly()
        {
            Console.WriteLine("Sparrow can fly");
        }
    }
}
