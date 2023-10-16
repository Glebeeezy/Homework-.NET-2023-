using HWCollections.MyClass;
using System.Collections;

namespace HWCollections
{
    public sealed class MyUserList : IEnumerable<User>
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

        private User[] _array;

        public User this[int index]
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

        public void Add(User item)
        {
            if (Count != 0 && Count == Capacity)
            {
                ResizeList();
            }
            _array[_count] = item;
            CountMethod();
            IComparer<User> comparer = new UserComparer();
            Sort(comparer);
        }
        private void Sort(IComparer<User>? comparer)
        {
            Array.Sort(_array, 0, Count, comparer);
        }
        public void RemoveAt(int index)
        {
            if (index > _array.Length || index < 0)
            {
                throw new Exception("IndexIsOutOfRengeExeption");
            }
            User[] array = new User[_array.Length];
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
            User[] array = new User[_array.Length * 2];
            for (int i = 0; i < _array.Length; i++)
            {
                array[i] = _array[i];
            }
            _array = array;
            Capacity = _array.Length;
        }

        public IEnumerator<User> GetEnumerator()
        {
            UserEnumerator enumerator = new(_array);
            return enumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            UserEnumerator enumerator = new(_array);
            return enumerator;
        }

        public MyUserList()
        {
            ListName = "MyList";
            _array = new User[4];
            Capacity = _array.Length;
        }
        public MyUserList(string name)
        {
            ListName = name;
            _array = new User[4];
            Capacity = _array.Length;
        }
        public MyUserList(string name, int startCapacityOfList)
        {
            ListName = name;
            _array = new User[startCapacityOfList];
            Capacity = _array.Length;
        }
    }
}
