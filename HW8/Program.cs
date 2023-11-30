using Bogus;
using HW8.Ex1;
using HW8.Ex2;
using HW8.Ex3;
using System.Linq.Expressions;

namespace HW8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ex1
            #region(ex1)
            Func<int, int, int> sum = (x, y) => x + y; 
            Calculation calculation = new Calculation();
            calculation.Calculate(sum, 37, 43);
            Func<int, int, int> subtraction = delegate(int x, int y) {  return x - y; };
            calculation.Calculate(subtraction, 15, 10);
            Func<int, int, int> multiply = (x, y) => x * y;
            calculation.Calculate(multiply, 2, 2);
            Func<int, int, int> divide = delegate (int x, int y) { return x / y; };
            calculation.Calculate(divide, 9, 2);
            #endregion(ex1)
            // ex2
            #region(ex2)
            List<MyPerson> persons = new List<MyPerson>(2500);
            for (int i = 0; i < persons.Capacity; i++)
            {
                Faker faker = new Faker(locale: "ru");
                string firstName = faker.Person.FirstName;
                string lastName = faker.Person.LastName;
                string department = faker.Commerce.Department(1);
                int age = faker.Random.Int(18, 63);
                MyPerson person = new MyPerson(firstName, lastName, age, department);
                persons.Add(person);
            }
            Func<MyPerson, bool> compareByAge = delegate (MyPerson person)
            {
                if (person.Age > 30)
                {
                    return true;
                }
                return false;
            };
            Func<MyPerson, bool> compareByDepartment = (person) => { return person.Department.StartsWith("Бух"); };
            PersonManager personManager = new PersonManager();
            var filteredPersons = personManager.Filter(compareByAge, persons);
            foreach (var item in filteredPersons)
            {
                Console.WriteLine($"Имя: {item.FirstName} Фамилия: {item.LastName} Возраст: {item.Age} Отдел: {item.Department}");
            }
            filteredPersons = personManager.Filter(compareByDepartment, persons);
            foreach (var item in filteredPersons)
            {
                Console.WriteLine($"Имя: {item.FirstName} Фамилия: {item.LastName} Возраст: {item.Age} Отдел: {item.Department}");
            }
            #endregion(ex2)
            //ex3
            #region(ex3)
            var newsProvider = new NewsProvider();
            var client = new Client(newsProvider);
            bool updating = true;
            while (updating) 
            {
                newsProvider.News(client.categorie);
                if (client.IsNewsUpdated())
                {
                    updating = false;
                }
            }
            #endregion(ex3)
        }
    }
}