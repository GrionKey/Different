using System;
using System.Linq;

namespace шифр_Луна
{
    class Program
    {


        static void Main(string[] args)
        {
            //char A1 = 'А'; 
            //Console.WriteLine((byte) A1);

            //char A2 = 'Б';
            //Console.WriteLine((byte)A2);
            //Console.ReadKey();
            string[] Bukv = new string[]
            {
                "А", "Б", "В", "Г", "Д", "Е", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Э", "Ю", "Я",
                 "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я"
            };
            string[] DeBukv = new string[]
            {
                "11000000", "11000001", "11000010", "11000011", "11000100", "11000101", "110000110", "11000111", "11001000", "11001001", "11001010", "11001011", "11001100", "11001101", "11001110", "11001111", "11010000", "11010001", "11010010", "11010011", "11010100", "11010101", "11010110", "11010110", "11011000", "11011001", "11011101", "11011110", "11011111",
                "11100000", "11100001", "11100010", "11100011", "11100100", "11100101", "111000110", "11100111", "11101000", "11101001", "11101010", "11101011", "11101100", "11101101", "11101110", "11101111", "11110000", "11110001", "11110010", "11110011", "11110100", "11110101", "11110110", "11110110", "11111000", "11111001", "11111010", "11111011", "11111100", "11111101", "11111110", "11111111",
            };
            string slovo = "";
            slovo = Console.ReadLine();

            char[] bukva;
            bukva = slovo.ToCharArray();

            foreach (char c in bukva)
            {
                for (int i = 0; i <= Bukv.Length - 1; i++)

                    if (Bukv[i].Contains(c))
                    {
                        Console.Write(Bukv[i] + " - " + DeBukv[i]);

                        int n = Convert.ToInt32(DeBukv[i]);
                        int s = 0;
                        while (n != 0)
                        {
                            s = s + n % 10;
                            n = n / 10;
                        }
                        if (s % 2 == 0)
                        {
                            Console.WriteLine(" - четное");
                        }
                        else Console.WriteLine(" - нечетное");

                    }
            }
            Console.ReadKey();
        }

    }
}


/*using System;
using System.Collections.Generic;
using System.Linq;

namespace TestConsole
{
/// <summary>
/// Класс который содержит символ и его порядковый номер в строке, зависящий от алфавита.
/// </summary>
class CharNum
{
    #region Fields
    /// <summary>
    /// Символ.
    /// </summary>
    private char _ch;
    /// <summary>
    /// Порядковый номер зависящий от алфавита.
    /// </summary>
    private int _numberInWord;
    #endregion Fieds

    #region Properties
    /// <summary>
    /// Символ.
    /// </summary>
    public char Ch
    {
        get { return _ch; }
        set
        {
            if (_ch == value)
                return;
            _ch = value;
        }
    }
    /// <summary>
    /// Порядковый номер в строке, зависящий от алфавита.
    /// </summary>
    public int NumberInWord
    {
        get { return _numberInWord; }
        set
        {
            if (_numberInWord == value)
                return;
            _numberInWord = value;
        }
    }
    #endregion Properties
}

class Program
{
    static void Main(string[] args)
    {
        // Первый ключ, количество столбцов
        string firstKey = "ервмит";
        // Второй ключ, количество строк
        string secondKey = "5322";
        // Предложение которое шифруем
        string stringUser = "енекпа";

        // Матрица в которой производим шифрование
        char[,] matrix = new char[secondKey.Length, firstKey.Length];

        // Счетчик символов в строке
        int countSymbols = 0;

        // Переводим строки в массивы типа char
        char[] charsFirstKey = firstKey.ToCharArray();
        char[] charsSecondKey = secondKey.ToCharArray();
        char[] charStringUser = stringUser.ToCharArray();

        // Создаем списки в которых будут храниться символы и порядковы номера символов
        List<CharNum> listCharNumFirst =
            new List<CharNum>(firstKey.Length);

        List<CharNum> listCharNumSecond =
            new List<CharNum>(secondKey.Length);

        // Заполняем символами из ключей
        listCharNumFirst = FillListKey(charsFirstKey);
        listCharNumSecond = FillListKey(charsSecondKey);

        // Заполняем порядковыми номерами
        listCharNumFirst = FillingSerialsNumber(listCharNumFirst);
        listCharNumSecond = FillingSerialsNumber(listCharNumSecond);

        ShowKey(listCharNumFirst, "Первый ключ: ");
        ShowKey(listCharNumSecond, "Второй ключ: ");

        // Заполнение матрицы строкой пользователя
        for (int i = 0; i < listCharNumSecond.Count; i++)
        {
            for (int j = 0; j < listCharNumFirst.Count; j++)
            {
                matrix[i, j] = charStringUser[countSymbols++];
            }
        }

        ShowMatrix(matrix, "Первоначальное значение: ");

        countSymbols = 0;
        // Заполнение матрицы с учетом шифрования. 
        // Переставляем столбцы по порядку следования в первом ключе. 
        // Затем переставляем строки по порядку следования во втором ключа. 
        for (int i = 0; i < listCharNumSecond.Count; i++)
        {
            for (int j = 0; j < listCharNumFirst.Count; j++)
            {
                matrix[listCharNumSecond[i].NumberInWord,
                   listCharNumFirst[j].NumberInWord] = charStringUser[countSymbols++];
            }
        }

        ShowMatrix(matrix, "Зашифрованное значение: ");

        Console.ReadKey();
    }

    #region Methods
    /// <summary>
    /// Возвращает порядковый номер символа по алфавиту.
    /// </summary>
    /// <param name="s">Символ, чей порядковый номер, необходимо узнать.</param>
    /// <returns></returns>
    public static int GetNumberInThealphabet(char s)
    {
        string str = @"АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя";

        int number = str.IndexOf(s) / 2;

        return number;
    }

    /// <summary>
    /// Заполнение символами списка с ключом.
    /// </summary>
    /// <param name="chars">массив символов.</param>
    /// <returns>Список символов.</returns>
    public static List<CharNum> FillListKey(char[] chars)
    {
        List<CharNum> listKey = new List<CharNum>(chars.Length);

        for (int i = 0; i < chars.Length; i++)
        {
            CharNum charNum = new CharNum()
            {
                Ch = chars[i],
                NumberInWord = GetNumberInThealphabet(chars[i])
            };

            listKey.Add(charNum);
        }
        return listKey;
    }
    /// <summary>
    /// Отображение ключа.
    /// </summary>
    /// <param name="listCharNum">Список в котором содержатся символы с порядковыми номерами.</param>
    public static void ShowKey(List<CharNum> listCharNum, string message)
    {
        Console.WriteLine(message);

        foreach (var i in listCharNum)
        {
            Console.Write(i.Ch + " ");
        }
        Console.WriteLine();

        foreach (var i in listCharNum)
        {
            Console.Write(i.NumberInWord + " ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    /// <summary>
    /// Заполнение символов ключей, порядковыми номерами.
    /// </summary>
    /// <param name="listCharNum"></param>
    /// <returns></returns>
    public static List<CharNum> FillingSerialsNumber(
        List<CharNum> listCharNum)
    {
        int count = 0;

        var result = listCharNum.OrderBy(a =>
            a.NumberInWord);

        foreach (var i in result)
        {
            i.NumberInWord = count++;
        }

        return listCharNum;
    }
    /// <summary>
    /// Отображение матрицы.
    /// </summary>
    /// <param name="matrix">Матрица с символами.</param>
    public static void ShowMatrix(char[,] matrix, string message)
    {
        Console.WriteLine(message);
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    #endregion Methods
}

}
*/