namespace HWCollections.MyClass
{
    public class UserComparer : IComparer<User>
    {
        public int Compare(User? fist, User? second)
        {
            if ((fist == null) || (!(fist is User)))
                return 0;
            else if ((second == null) || (!(second is User)))
                return 0;
            else
                return fist.Id.CompareTo(second.Id);
        }
    }
}
