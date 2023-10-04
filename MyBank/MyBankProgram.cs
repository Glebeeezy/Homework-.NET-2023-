namespace MyBank
{
    internal class MyBankProgram
    {
        static void Main(string[] args)
        {
            var alphabank = NationalBank.CreateBank(name: "Alphabank", version: "first");

            alphabank.PrintVersion();

            alphabank.PrintName();

            Bank.PressService.PrintDirectorName(alphabank);
        }
    }
}