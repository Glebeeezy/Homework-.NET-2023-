namespace MyBank
{
    public class Bank
    {
        public class PressService
        {
            public static void PrintDirectorName(Bank bank)
            {
                Console.WriteLine(bank._directorName);
            }
        }
        private readonly string _directorName = "Gleb";
        public string Name { get; init; }
        public string? Version { get; init; }
        public void PrintName()
        {
            Console.WriteLine(Name);
        }
        public void PrintVersion()
        {
            Console.WriteLine(Version);
        }

        public Bank(string name, string version)
        {
            Name = name;
            Version = version;
        }

        public Bank(string name)
        {
            Name = name;
        }

    }
}
