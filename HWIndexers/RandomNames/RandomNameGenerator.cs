using System.Text;

namespace HWIndexers.RandomNames
{
    public sealed class RandomNameGenerator
    {
        private string[] _namesRootWords = new[] { "Ast", "Lor", "Bel", "Tor", "Zel", "Mer" };

        private int[] _randomIndexes = new int[3];


        private void GetRandomArrayOfIndexes()
        {
            Random random = new Random();

            bool isArrayUniqe = false;

            while (!isArrayUniqe)
            {
                _randomIndexes[0] = random.Next(0, 5);
                _randomIndexes[1] = random.Next(0, 5);
                _randomIndexes[2] = random.Next(0, 5);
                isArrayUniqe = IsArrayAreUniqe();
            }
        }

        private bool IsArrayAreUniqe()
        {      
            if (_randomIndexes[0] == _randomIndexes[1] || _randomIndexes[0] == _randomIndexes[2])
            {
                return false;
            }
            else if (_randomIndexes[1] == _randomIndexes[2])
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public string GetRandomName()
        {
            GetRandomArrayOfIndexes();
            StringBuilder stringBuilder = new StringBuilder($"{_namesRootWords[_randomIndexes[0]]} {_namesRootWords[_randomIndexes[1]]} {_namesRootWords[_randomIndexes[2]]}");
            return stringBuilder.ToString();
        }
    }
}

