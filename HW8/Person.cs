namespace HW8
{
    internal class Person
    {
        public string FirstName { get; init; }

        public string LastName { get; init; }

        public int Age { get; protected set; }

        public string Department { get; protected set; }

        public Person(string firstName, string lastName, int age, string department) 
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Department = department;
        }
    }
}
