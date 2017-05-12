namespace _04.SplitByWordCasing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SplitByWordCasing
    {
        public static void Main()
        {
            var text = Console.ReadLine().
                Split(new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();

            foreach (var word in text)
            {
                var countUpper = 0;
                var countLower = 0;

                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                        countLower++;
                    else if (char.IsUpper(word[i]))
                        countUpper++;
                }

                if (countLower == word.Length)
                    lowerCase.Add(word);
                else if (countUpper == word.Length)
                    upperCase.Add(word);
                else
                    mixedCase.Add(word);
            }

            Console.WriteLine("Lower-case: {0}", string.Join(", ", lowerCase));
            Console.WriteLine("Mixed-case: {0}", string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: {0}", string.Join(", ", upperCase));
        }
    }
}
