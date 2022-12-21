using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var x = 5;
                var y = x / 0;
                Console.WriteLine($"Результат: {y}");
                Console.WriteLine("клнец программы");
                Console.Read();
            }
            catch { Console.WriteLine("возникло исключение"); }

            finally { Console.WriteLine("блок finally"); }

            Console.WriteLine("конец программы");
            Console.Read();
        }
    }
}
