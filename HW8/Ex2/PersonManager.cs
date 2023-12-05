namespace HW8.Ex2
{
    internal class PersonManager
    {
        public IEnumerable<MyPerson> Filter(Func<MyPerson, bool> filter, IEnumerable<MyPerson> collection)
        {
            if (collection == null)
            {
                throw new NullReferenceException("CollectionIsEmpty");
            }
            List<MyPerson> list = collection.Where(person => filter(person)).ToList();
            return list;
        }
    }
}
