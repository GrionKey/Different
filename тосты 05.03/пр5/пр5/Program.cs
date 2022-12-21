using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пр5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int login,password;
            try
            {
                Console.WriteLine("Пользователь 1: логин-11111, пароль-66666;\nПользователь 2: логин-12345, пароль-57834;\nПользователь 3: логин-55555, пароль-77777.\n");
                Console.Write("Введите логин:");
                login=Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите пароль:");
                password=Convert.ToInt32(Console.ReadLine());
                if (login==11111 )
                {
                    if (password == 66666)
                    {
                        Console.WriteLine("Вы вошли в систему под именем Пользователь 1");
                    }
                    else
                    {
                        Console.WriteLine("Введён неверный пароль");

                    }
                }
                else
                {
                    if (login==12345 )
                        if (password == 57834)
                        {
                            Console.WriteLine("Вы вошли в систему под именем Пользователь 2");
                        }
                    else
                    {
                            Console.WriteLine("Введён неверный пароль");
                    }
                    else
                    {
                        if (login==55555 )
                            if (password == 77777)
                            {
                                Console.WriteLine("Вы вошли в систему под именем Пользователь 3");
                            }
                        else
                        {
                                Console.WriteLine("Введён неверный пароль");
                            }
                        else
                        {
                            Console.WriteLine("Такого пользователя не существует");
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Введён неверный логин или пароль");
            }
            Console.ReadLine();
        }
    }
}
