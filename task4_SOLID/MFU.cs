using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4_SOLID
{
    internal class MFU : IPrinter, IScanner
    {
        public void Print(string document)
        {
            Console.WriteLine($"Напечатан документ  с помощью МФУ: {document}");
        }

        public string Scan()
        {
            return "Сканирование завершено";
        }
    }
}
