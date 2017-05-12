namespace _03.TextFilter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TextFilter
    {
        public static void Main()
        {
            var bannedWords = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);


            var text = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                if (text.Contains(bannedWord))
                {
                    text = text.Replace(bannedWord, new string('*', bannedWord.Length));
                }

            }

            Console.WriteLine(text);
        }
    }
}
