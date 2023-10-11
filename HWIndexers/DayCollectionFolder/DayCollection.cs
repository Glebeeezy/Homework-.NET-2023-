using HWIndexers.DayCollectionFolder.Enums;

namespace HWIndexers.DayCollectionFolder
{
    public sealed class DayCollection
    {
        public int this[WeekStyle weekStyle, WeekDay weekDay]
        {
            get
            {
                if (weekStyle == WeekStyle.American)
                {
                    switch (weekDay)
                    {
                        case WeekDay.Sunday:
                            return 1;
                        case WeekDay.Monday:
                            return 2;
                        case WeekDay.Tuesday:
                            return 3;
                        case WeekDay.Wednesday:
                            return 4;
                        case WeekDay.Thursday:
                            return 5;
                        case WeekDay.Friday:
                            return 6;
                        case WeekDay.Saturday:
                            return 7;
                        default: throw new Exception("Unknown Property Name");
                    }
                }
                else if (weekStyle == WeekStyle.European)
                {
                    switch (weekDay)
                    {
                        case WeekDay.Sunday:
                            return 7;
                        case WeekDay.Monday:
                            return 1;
                        case WeekDay.Tuesday:
                            return 2;
                        case WeekDay.Wednesday:
                            return 3;
                        case WeekDay.Thursday:
                            return 4;
                        case WeekDay.Friday:
                            return 5;
                        case WeekDay.Saturday:
                            return 6;
                        default: throw new Exception("Unknown Property Name");
                    }
                }
                else
                {
                    throw new Exception("Unknown Property Name");
                }
            }       
        }
    }
}
