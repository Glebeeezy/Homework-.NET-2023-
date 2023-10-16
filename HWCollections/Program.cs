using Bogus;
using HWCollections.MyClass;
using System.Collections;
using HWCollections.Books; 

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
            void ShowMyList(MyUserList list)
            {
                Console.WriteLine("MyListChange");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.Write($"{list[i].FirstName} {list[i].LastName} {list[i].Id}\n");
                }
            }

            User gleb = new(firstName: "Gleb", lastName: "Malysheu", id: 1);
            User sasha = new(firstName: "Sasha", lastName: "Vorobey", id: 2);
            User petya = new(firstName: "Petya", lastName: "Yakubuk", id: 3);
            User vasya = new(firstName: "Vasya", lastName: "Shubich", id: 4);
            User vadim = new(firstName: "Vadim", lastName: "Vinnikov", id: 5);
            User denis = new(firstName: "Denis", lastName: "Kovsh", id: 6);
            User stas = new(firstName: "Stas",lastName: "Voitovich", id: 7);

            MyUserList myList = new() { petya, vasya, sasha, denis, vadim, stas };
            ShowMyList(myList);
            myList.Add(gleb);
            ShowMyList(myList);

            // Exercise 3
            DateTime dayNow = DateTime.Now;

            long GetKey(Book book)
            {
                TimeSpan delta = dayNow - new DateTime(dayNow.Year, dayNow.Month, dayNow.Day);

                DateTime current = book.dateOfBookCreation + delta;

                long key = current.Ticks;

                return key;
            }

            Dictionary<long, string> dictionary = new(5000);

            BookCreator bookCreator = new();

            for (int i = 0; i < 5000; i++)
            {
                Book book = bookCreator.GetBook();
                long key = GetKey(book);
                dictionary.Add(key, book.bookName);
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine($"Ключ {item.Key} значение {item.Value}");
            }
        }
    }
}