using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_SOLID
{
    internal class Printer : IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"Напечатан документ: {document}");
        }
    }
}
