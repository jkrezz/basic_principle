using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1_generic
{
    internal class Pair<T, U>
    {
        public T _first /*{ get; set; }*/;
        public U _second /*{ get; set; }*/;

        public Pair(T first, U second)
        {
            _first = first;
            _second = second;
        }

        public T First
        {
            get { return _first; }
            set { _first = value; }
        }

        public U Second
        {
            get { return _second; }
            set { _second = value; }
        }
    }

}
