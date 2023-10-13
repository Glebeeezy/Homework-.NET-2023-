using System.Collections;

namespace HWCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            void ShowArrayList(ArrayList list)
            {
                Console.WriteLine($"ArrayList");
                foreach (var item in list)
                {
                    Console.Write($"{item}\t");
                }
                Console.WriteLine();
            }
            void ShowList(List<string> list)
            {
                Console.WriteLine("List<T>");
                foreach (var item in list)
                {
                    Console.Write($"{item}\t");
                }
                Console.WriteLine();
            }
            ArrayList arrayList = new ArrayList() {"Gleb", "Sasha", "Vadim", "Pyotr" };

            List<string> list = new List<string>() {"Dasha", "Nastya", "Katya", "Alesya" };

            arrayList.Add("1");
            ShowArrayList(arrayList);
            arrayList.Add("2");
            ShowArrayList(arrayList);
            list.Add("1");
            ShowList(list);
            list.Add("2");
            ShowList(list);

            arrayList.RemoveAt(3);
            ShowArrayList(arrayList);
            list.RemoveAt(3);
            ShowList(list);

            arrayList.RemoveAt(0);
            ShowArrayList(arrayList);
            list.RemoveAt(0);
            ShowList(list);

            arrayList.Sort();
            list.Sort();
            ShowArrayList(arrayList);
            ShowList(list);

            // Exercise 2
            Console.WriteLine("Exercise 2");

            
        }
    }
}