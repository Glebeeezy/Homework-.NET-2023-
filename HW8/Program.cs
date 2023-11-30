using Bogus;
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
            List<Person> persons = new List<Person>(2500);
            for (int i = 0; i < persons.Capacity; i++)
            {
                Faker faker = new Faker(locale: "ru");
                string firstName = faker.Person.FirstName;
                string lastName = faker.Person.LastName;
                string department = faker.Commerce.Department(1);
                int age = faker.Random.Int(18, 63);
                Person person = new Person(firstName, lastName, age, department);
                persons.Add(person);
            }
            Func<Person, bool> compareByAge = delegate (Person person)
            {
                if (person.Age > 30)
                {
                    return true;
                }
                return false;
            };
            Func<Person, bool> compareByDepartment = (person) => { return person.Department.StartsWith("Бух"); };
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

            #endregion(ex3)
        }
    }
}