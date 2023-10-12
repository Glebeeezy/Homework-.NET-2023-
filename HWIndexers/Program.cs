using HWIndexers.DayCollectionFolder;
using HWIndexers.DayCollectionFolder.Enums;
using HWIndexers.Tempreture;
using HWIndexers.Tempreture.Enums;
using HWIndexers.Rating;
using HWIndexers.RandomNames;
using HWIndexers.Versions;

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
            Days day = Days.Thirdty;
            Month month = Month.April;
            termometer[month, day] = 12;
            Console.WriteLine(termometer[month, day]);

            // Exercise 1.3

            StudentsRating rating = new();
            rating["A", "Malyshev"] = 7;
            Console.WriteLine(rating["A", "Malyshev"]);

            // Exercise 2

            RandomNameGenerator randomNameGenerator = new();
            Console.WriteLine(randomNameGenerator.GetRandomName());
            Console.WriteLine(randomNameGenerator.GetRandomName());
            Console.WriteLine(randomNameGenerator.GetRandomName());
            Console.WriteLine(randomNameGenerator.GetRandomName());

            // Exercise 3

            ComparisonOfStrings comparisonOfStrings = new ComparisonOfStrings();

            Console.WriteLine(comparisonOfStrings.CompareVersions("1.10.1", "1.9.9"));
            Console.WriteLine(comparisonOfStrings.CompareVersions("1.01.1", "1.1.1"));
            Console.WriteLine(comparisonOfStrings.CompareVersions("2.2.2", "3.3.3"));
        }
    }
}