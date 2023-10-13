using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWCollections
{
    public sealed class MyList<T>
    {
        public string ListName { get; init; }

        private int _capacity;

        public int Capacity
        {
            get { return _capacity; }
            private set { _capacity = _array.Length; }
        }

        private int _count;

        public int Count
        {
            get { return _count; }
            private set {}
        }

        private T[] _array;

        public T this[int index]
        {
            get
            {
                if (_array[index] != null)
                {
                    return _array[index];
                }
                else
                {
                    throw new Exception("IndexIsOutOfRangeExeption");
                }
            }
            set
            {
                if (index > _array.Length || index < 0)
                {
                    throw new Exception("IndexIsOutOfRangeExeption");
                }
                _array[index] = value;
                CountMethod();
            }
        }

        public void Add(T item)
        {
            if (Count != 0 && Count == Capacity)
            {
                ResizeList();
            }
            _array[_count] = item;
            CountMethod();
            Sort();
        }
        private void Sort(IComparer<T>? comparer)
        {
            Array.Sort<T>(_array, 0, Count, comparer);
        }
        public void RemoveAt(int index)
        {
            if (index > _array.Length || index < 0)
            {
                throw new Exception("IndexIsOutOfRengeExeption");
            }
            T[] array = new T[_array.Length];
            for (int i = 0; i < index; i++)
            {
                array[i] = _array[i];
            }
            for (int i = index + 1; i < array.Length; i++)
            {
                if (_array[i] == null)
                {
                    break;
                }
                array[i - 1] = _array[i];
            }
            _array = array;
            CountMethod();
        }
        private void CountMethod()
        {
            int counter = 0;
            foreach (var item in _array)
            {
                if (item != null)
                {
                    counter++;
                }
            }
            _count = counter;
        }

        private void ResizeList()
        {
            T[] array = new T[_array.Length * 2];
            for (int i = 0; i < _array.Length; i++)
            {
                array[i] = _array[i];
            }
            _array = array;
            Capacity = _array.Length;
        }

        public MyList()
        {
            ListName = "MyList";
            _array = new T[4];
            Capacity = _array.Length;
        }
        public MyList(string name)
        {
            ListName = name;
            _array = new T[4];
            Capacity = _array.Length;
        }
        public MyList(string name, int startCapacityOfList)
        {
            ListName = name;
            _array = new T[startCapacityOfList];
            Capacity = _array.Length;
        }
    }
}
