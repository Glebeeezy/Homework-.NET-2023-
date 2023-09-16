using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculatorHW
{
     internal static class DoubleCalculatorControl
    {
        public static void RunCalculator()
        {
            Console.WriteLine("Введите название калькулятора");

            string name = Console.ReadLine();

            DoubleCalculator calculator = new DoubleCalculator(name);

            bool controller = true;
            while (controller)
            {
                calculator.Calculate();
                controller = Controller();
            }
        }

        private static bool Controller()
        {
            Console.WriteLine("Введите 1 если хотите продолжить вычисления\nВведите 2 если хотите прекратить");

            int number = int.Parse(Console.ReadLine());

            if (number == 1)
            {
                return true;
            }

            else if (number == 2)
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
