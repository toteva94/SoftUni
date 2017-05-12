namespace _07.CountOfCapitalLettersInArray
{
    using System;
    using System.Linq;

    class CountOfCapitalLettersInArray
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToArray();

            var count = 0;

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];

                if (currentWord.Length == 1)
                {
                    char toChar = currentWord[0];
                    if (toChar >= 'A' || toChar <= 'Z')
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine(count);
        }
    }
}
