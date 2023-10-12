namespace HWIndexers.Rating
{
    public class StudentsRating
    {
        private int[,] _rating = new int[4, 15];

        private string[] _classLetters = new string[4] { "A", "B", "C", "D" };

        private string[] _StudentsLastNames = new string[15] 
        { "Malyshev", "Vodchits", "Gurinovich", "Shubitch", "Babich", "Markovsky", "Vorobey", "Vlazovskaya",
        "Urubkov", "Khlust", "Kondrashkina", "Vanin", "Timofeyev", "Stasuk", "Yakunovich"};


        public int this[string classLetter, string lastName]
        {
            get
            {
                int[] indexes = RatingIndexes(classLetter, lastName);
                return _rating[indexes[0], indexes[1]];
            }
            set
            {
                int[] indexes = RatingIndexes(classLetter, lastName);
                _rating[indexes[0], indexes[1]] = value;
            }
        }     

        private int[] RatingIndexes(string classLetter, string lastName)
        {
            int[] result = new int[2];
            // result array 0 = index of class, 1 = index of student
            bool nameIsFound = false;
            bool classLetterIsFound = false;
            for (int i = 0; i < _classLetters.Length; i++)
            {
                if (_classLetters[i] == classLetter)
                {
                    result[0] = i;
                    classLetterIsFound = true;
                    break;
                }
                else if(i == _classLetters.Length - 1 && !classLetterIsFound)
                {
                    throw new Exception($"There is no class {classLetter}");
                }
            }
            for (int i = 0; i < _StudentsLastNames.Length; i++)
            {
                if (_StudentsLastNames[i] == lastName)
                {
                    result[1] = i;
                    nameIsFound = true;
                    break;
                }
                else if(i == _StudentsLastNames.Length - 1 && !nameIsFound)
                {
                    throw new Exception($"There is no student {lastName}");
                }
            }
            return result;
        }
    }
}
