using System.Collections.Generic;

namespace _01.ReverseStrings
{
    using System;
    public class ReverseStrings
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var words = new Stack<char>();
            var reversedWords = new List<char>();

            foreach (var @char in input)
            {
                words.Push(@char);
            }

            while(words.Count > 0)
            {
                var currentChar = words.Pop();
                reversedWords.Add(currentChar);
            }

            Console.WriteLine(string.Join("",reversedWords));
        }
    }
}