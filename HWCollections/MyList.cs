using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCollections
{
    public sealed class MyList
    {
        public string ListName { get; init; }

        private int _capacity;

        public int Capacity
        {
            get { return _capacity; }
            private set { _capacity = _array.Length; }
        }

        private int _numberOfElements;

        public int NumberOfElements
        {
            get { return _numberOfElements; }
            private set { _numberOfElements = NumberOfElementsMethod(); }
        }

        private object?[] _array = new object[4];

        public void Add(string item)
        {
            if (NumberOfElements == Capacity)
            {
                ResizeList();
            }
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] == null)
                {
                    _array[i] = item;
                }
            }
            Sort();
        }
        public void Sort()
        {
            _array.Order();
        }
        
        public void DeleteAt(int index)
        {
            _array[index] = null;
        }
        private int NumberOfElementsMethod()
        {
            int counter = 0;
            foreach (var item in _array)
            {
                if (item != null)
                {
                    counter++;
                }
            }
            return counter;
        }

        private void ResizeList()
        {
            object?[] array = new object[_array.Length * 2];
            for (int i = 0; i < _array.Length; i++)
            {
                array[i] = _array[i];
            }
            _array = array;
        }

        public MyList(string name)
        {
            ListName = name;
        }
    }
}
