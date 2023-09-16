namespace MyCalculatorHW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название калькулятора");

            string name = Console.ReadLine();

            DoubleCalculator calculator = new DoubleCalculator(name);

            bool controller = true;
            while (controller)
            {
                calculator.Calculate();
                controller =Controller();
            }

            bool Controller()
            {
                Console.WriteLine("Введите 1 если хотите продолжить вычисления\nВведите 2 если хотите прекратить");

                int number = int.Parse(Console.ReadLine());

                if (number == 1)
                {
                    return true;
                }

                else if(number == 2)
                {
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}