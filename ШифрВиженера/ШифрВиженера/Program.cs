using System;

namespace ШифрВиженера
{
    public class VigenereCipher
    {
        const string defultAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; //
        readonly string letters;

        public VigenereCipher(string alphabet = null)
        {
            letters = string.IsNullOrEmpty(alphabet) ? defultAlphabet : alphabet;
        }

        //генерация повторяющегося пароля
        private string GetReapetKey(string s, int n)
        {
            var p = s;
            while(p.Length < n)
            {
                p += p;
            }
            return p.Substring(0, n);
        }

        private string Vigenere(string text, string password, bool encrypting = true)
        {
            var gamma = GetReapetKey(password, text.Length);
            var retValue = "";
            var q = letters.Length;

            for (int i = 0; i < text.Length; i++)
            {
                var letterIndex = letters.IndexOf(text[i]);
                var codeIndex = letters.IndexOf(gamma[i]);
                if (letterIndex < 0)
                {
                    // если буква не найдена, добавляем ее в исходном виде
                    retValue += text[i].ToString();
                }
                else
                {
                    retValue += letters[(q + letterIndex + ((encrypting ? 1 : -1) * codeIndex)) % q].ToString();
                }
            }
            return retValue;
        }

        // шифрование текста
        public string Encrypt(string plainMessge, string password) => Vigenere(plainMessge, password);

        // дешифрование текста 
        public string Decrypt(string encryptedMessge,string password) => Vigenere(encryptedMessge,password,false);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // передаем в конструктор класса буквы русского алфавита
            var chipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪФЬЭЮЯ");
            Console.Write("Введите текст:   ");
            var inputText = Console.ReadLine().ToUpper();
            Console.Write("Введите ключ шифрования: ");
            var password = Console.ReadLine().ToUpper();
            var encryptedText = chipher.Encrypt(inputText, password);
            Console.WriteLine("Зашифрованное сообщение:    {0}", encryptedText);
            Console.WriteLine("Расшифрованное сообщение {0}", chipher.Decrypt(encryptedText,password));
            Console.ReadLine();

        }
    }
}
