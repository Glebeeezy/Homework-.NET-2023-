namespace MyCalculatorHW
{
    internal class DoubleCalculator
    {
        public readonly string _calculatorName;

        private const string _endCalcMessage = "Результат вычисления:\t";

        private double _numberOne { get; set; }

        private double _numberTwo { get; set; }

        private double Sum()
        {
            return _numberOne + _numberTwo;
        }

        private double Subtract()
        {
            return _numberOne - _numberTwo;
        }

        private double Multiply()
        {
            return _numberOne * _numberTwo;
        }

        private double Divide()
        {
            return _numberOne / _numberTwo;
        }
        public void Calculate()
        {
            Console.WriteLine("Введите номер операции которую хотите выполнить\n1: Сложение\t2: Вычитание\t3: Умножение\t4: Деление");

            int choosenOperation = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите первое число");

            _numberOne = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число");

            _numberTwo = double.Parse(Console.ReadLine());

            double result;

            switch (choosenOperation)
            {
                case 1:
                    result = Sum();
                    Console.WriteLine(_endCalcMessage + $"{_numberOne} + {_numberTwo} = " + result);
                    break;
                case 2:
                    result = Subtract();
                    Console.WriteLine(_endCalcMessage + $"{_numberOne} - {_numberTwo} = " + result);
                    break;
                case 3:
                    result = Multiply();
                    Console.WriteLine(_endCalcMessage + $"{_numberOne} * {_numberTwo} = " + result);
                    break;
                case 4:
                    result = Divide();
                    Console.WriteLine(_endCalcMessage + $"{_numberOne} / {_numberTwo} = " + result);
                    break;
                default:
                    Console.WriteLine("");
                    break;
            }
        }

        public DoubleCalculator(string name)
        {
            _calculatorName = name;
        }
    }
}
