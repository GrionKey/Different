using System;

namespace Консоль_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1000;
            int b = 30000;
            try
            {
                checked
                {
                    Console.WriteLine(a * a * b);
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            //catch
            //{
            //    Console.WriteLine("Неопознанная ошибка");
            //}
            Console.ReadKey();
        }
    }
}
