namespace MyBank
{
    public static class NationalBank
    {
        public static Bank CreateBank(string name)
        {
            Bank bank = new Bank(name);
            return bank;
        }
        public static Bank CreateBank(string name, string version)
        {
            Bank bank = new Bank(name, version);
            return bank;
        }
    }
}
