using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;  // делимое
            double b = 0;  // делитель

            Console.WriteLine("Введите делимое: ");
            a = Convert.ToInt32(Console.ReadLine());    // Ввод делимого с клавиатуры
            Console.WriteLine("Введите делитель: ");
            b = Convert.ToDouble(Console.ReadLine());    // Ввод делителя с клавиатуры

            try
            {
                double C = a/b;
                Console.WriteLine($"Результат: {C}");   // Вывод результата
            }
            catch
            {
                Console.WriteLine("Произошла ошибка, деление невозможно");  // Вывод информации об ошибке
            }

            Console.WriteLine("нажмите любую клавишу чтобы выйти");
            Console.ReadKey();
        }
    }
}
