using System;

// Z = sin(x)/(x-5)

namespace Консоль_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите значение X:  ");     // Подсказка о вводе значения
                int x = int.Parse(Console.ReadLine());          // Ввод значения X

                // Преобразование типа данных
                double a = (double)x;

                double z = Math.Round(Math.Sin(x) / (x - 5), 3);
                Console.WriteLine("sin(x)/(x-5) = {0}", z);

                if (double.IsInfinity(z)) Console.WriteLine("Ошибка при делении на ноль");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
