using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HWCollections.MyClass
{
    public class Person : IComparable<Person>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public int Id { get; set; }

        public Person(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        public int CompareTo(Person? other)
        {
            if ((other == null) || (!(other is Person)))
                return 0;
            else
                return LastName.CompareTo(other.LastName);
        }
    }
}
