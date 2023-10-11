using HWIndexers.DayCollectionFolder;
using HWIndexers.DayCollectionFolder.Enums;
using HWIndexers.Tempreture;
using HWIndexers.Tempreture.Enums;

namespace HWIndexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1.1
            WeekStyle weekStyleUs = WeekStyle.American;
            WeekStyle weekStyleEu = WeekStyle.European;

            WeekDay weekDay = WeekDay.Saturday;

            DayCollection dayCollection = new DayCollection();
            Console.WriteLine(dayCollection[weekStyleEu, weekDay]);
            Console.WriteLine(dayCollection[weekStyleUs, weekDay]);

            // Exercise 1.2

            Termometer termometer = new();
            Days day = Days.ThirdtyOne;
            Month month = Month.April;
            termometer[month, day] = 12;
            Console.WriteLine(termometer[month, day]);

            // Exercise 1.3


        }
    }
}