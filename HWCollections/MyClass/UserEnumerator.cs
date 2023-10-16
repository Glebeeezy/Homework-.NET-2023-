using System.Collections;

namespace HWCollections.MyClass
{   
        public class UserEnumerator : IEnumerator<User>
        {
            private User[] _persons;

            private int _position = -1;

            public User Current
            {
                get
                {
                    if (_position == -1 || _position >= _persons.Length)
                        throw new ArgumentException("Я ничего не понимаю");
                    return _persons[_position];
                }
            }

            object IEnumerator.Current
            {
                get
                {
                    if (_position == -1 || _position >= _persons.Length)
                        throw new ArgumentException("И тут тоже");
                    return _persons[_position];
                }
            }


            public void Dispose()
            {

            }

            public bool MoveNext()
            {
                if (_position < _persons.Length - 1)
                {
                    _position++;
                    return true;
                }
                else
                    return false;
            }

            public void Reset()
            {
                _position = -1;
            }

            public UserEnumerator(User[] persons)
            {
                _persons = persons;
            }
        }
}
