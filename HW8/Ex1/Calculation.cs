using System.Diagnostics;

namespace HW8.Ex1
{
    internal class Calculation
    {
        public int Calculate(Func<int, int, int> func, int a, int b)
        {
            Console.WriteLine("Вычисления начались");
            var sw = new Stopwatch();
            sw.Start();
            int result = func(a, b);
            sw.Stop();
            Console.WriteLine($"Вычисления завершены- время выполнения {sw.ElapsedMilliseconds} миллисекунд, результат вычисления {result}");
            return result;
        }
    }
}
