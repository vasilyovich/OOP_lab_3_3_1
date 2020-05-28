using System;

namespace OOP_lab_3_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string[] words = text.Split(new char[] { '\n', '\r', ' ', ':', ';', '.', ',', '?', '!', '(', ')', '{', '}', '[', ']', '@', '#', '№', '$', '^', '%', '&', '*', '/', '|' }, StringSplitOptions.RemoveEmptyEntries);

            int k = 0;

            for (int i = 0; i < words.Length; ++i)
            {
                if ((words[i][words[i].Length - 1] == 'A') || (words[i][words[i].Length - 1] == 'E') || (words[i][words[i].Length - 1] == 'I') || (words[i][words[i].Length - 1] == 'O') || (words[i][words[i].Length - 1] == 'U') || (words[i][words[i].Length - 1] == 'Y')) ++k;
                if ((words[i][words[i].Length - 1] == 'a') || (words[i][words[i].Length - 1] == 'e') || (words[i][words[i].Length - 1] == 'i') || (words[i][words[i].Length - 1] == 'o') || (words[i][words[i].Length - 1] == 'u') || (words[i][words[i].Length - 1] == 'y')) ++k;
                if ((words[i][words[i].Length - 1] == 'А') || (words[i][words[i].Length - 1] == 'О') || (words[i][words[i].Length - 1] == 'У') || (words[i][words[i].Length - 1] == 'И') || (words[i][words[i].Length - 1] == 'І') || (words[i][words[i].Length - 1] == 'Е') || (words[i][words[i].Length - 1] == 'Я') || (words[i][words[i].Length - 1] == 'Ю') || (words[i][words[i].Length - 1] == 'Є') || (words[i][words[i].Length - 1] == 'Ї')) ++k;
                if ((words[i][words[i].Length - 1] == 'а') || (words[i][words[i].Length - 1] == 'о') || (words[i][words[i].Length - 1] == 'у') || (words[i][words[i].Length - 1] == 'и') || (words[i][words[i].Length - 1] == 'і') || (words[i][words[i].Length - 1] == 'е') || (words[i][words[i].Length - 1] == 'я') || (words[i][words[i].Length - 1] == 'ю') || (words[i][words[i].Length - 1] == 'є') || (words[i][words[i].Length - 1] == 'ї')) ++k;
            }

            Console.WriteLine("\nKiлькiсть слiв у текстi, якi закiнчуються на голосну лiтеру: {0}", k);

            Console.Write("\nCлова, довжина яких менша п'яти символiв: ");

            foreach (string word in words)
            {
                if (word.Length < 5)
                {
                    Console.Write("{0} ", word);
                }
            }
            
        }
    }
}
