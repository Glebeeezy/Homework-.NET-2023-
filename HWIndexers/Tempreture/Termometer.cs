using HWIndexers.Tempreture.Enums;

namespace HWIndexers.Tempreture
{
    public class Termometer
    {
        private int[,] _temperature = new int[12,31];
        public int this[Month month, Days day]
        {
            get
            {
                if (month == Month.February)
                {
                    if (day >= Days.TwentyNine)
                    {
                        throw new Exception("IndexIsOutOfRangeException");
                    }
                }
                else if(month == Month.April)
                {
                    if(day == Days.ThirdtyOne) { throw new Exception("IndexIsOutOfRangeException"); }
                }
                else if(month == Month.June)
                {
                    if (day == Days.ThirdtyOne) { throw new Exception("IndexIsOutOfRangeException"); }
                }
                else if (month == Month.September)
                {
                    if (day == Days.ThirdtyOne) { throw new Exception("IndexIsOutOfRangeException"); }
                }
                else if (month == Month.November)
                {
                    if (day == Days.ThirdtyOne) { throw new Exception("IndexIsOutOfRangeException"); }
                }

                return _temperature[(int)month - 1, (int)day - 1];
            }
            set
            {
                if (month == Month.February)
                {
                    if (day >= Days.TwentyNine)
                    {
                        throw new Exception("IndexIsOutOfRangeException");
                    }
                }
                else if (month == Month.April)
                {
                    if (day == Days.ThirdtyOne) { throw new Exception("IndexIsOutOfRangeException"); }
                }
                else if (month == Month.June)
                {
                    if (day == Days.ThirdtyOne) { throw new Exception("IndexIsOutOfRangeException"); }
                }
                else if (month == Month.September)
                {
                    if (day == Days.ThirdtyOne) { throw new Exception("IndexIsOutOfRangeException"); }
                }
                else if (month == Month.November)
                {
                    if (day == Days.ThirdtyOne) { throw new Exception("IndexIsOutOfRangeException"); }
                }

                _temperature[(int)month - 1, (int)day -1] = value;
            }
        }

    }
}
