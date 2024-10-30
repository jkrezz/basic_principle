using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3_generic
{
    internal class Repository<T> where T : class
    {
        private readonly List<T> _items;

        public Repository()
        {
            _items = new List<T>();
        }

        public void Add(T item)
        {
            if (item != null)
                _items.Add(item);
        }

        public T? Get(int index)
        {   
            if (index >= 0 && index < _items.Count)
                 return _items[index];
            return default;
        }

        public int Count => _items.Count;
    }
}
