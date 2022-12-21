using System;

namespace Консоль_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] DW = { "Вс", "Пн", "Вт", "Ср", "Чт", "Пт", "Сб" };
            Console.Write("Введите неомер дня недели (0-6)  ");

            try
            {
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine("{0}, до Вс {1} дней", DW[i], 6 - i);
            }
            // Исключение, возникающее при вводе числа находящегося за границами коллекции
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            // Исключение, которое возникает в случае, если формат аргумента недопустим.
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            // Исключение возникающее при других ошибках
            catch
            {
                Console.WriteLine("Возникла ошибка");
            }
            Console.ReadKey();
        }
    }
}
