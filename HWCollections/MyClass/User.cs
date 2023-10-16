using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HWCollections.MyClass
{
    public class User : IComparable<User>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public int Id { get; init; }

        public User(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        public int CompareTo(User? other)
        {
            if ((other == null) || (!(other is User)))
                return 0;
            else
                return Id.CompareTo(other.Id);
        }
    }
}
