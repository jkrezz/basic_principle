﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_SOLID
{
    internal class Penguin : Bird
    {
        public override void Say()
        {
            Console.WriteLine("Penguin says...");
        }
    }
}