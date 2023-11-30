namespace HW8
{
    internal class PersonManager
    {
        public IEnumerable<Person> Filter(Func<Person, bool> filter, IEnumerable<Person> collection)
        {
            if (collection == null)
            {
                throw new NullReferenceException("CollectionIsEmpty");
            }
            List<Person> list = collection.Where(person => filter(person)).ToList();
            return list;
        }
    }
}
