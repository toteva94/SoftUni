namespace _04.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Palindromes
    {
        public static void Main()
        {
            var text = Console.ReadLine().Split(new char[] {' ',',','?','.','!'},StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new List<string>();

            foreach (var word in text)
            {
                var reversed = new string(word.Reverse().ToArray());
                var Ispalindrome = word == reversed;
                if (Ispalindrome)
                    palindromes.Add(word);
            }

            var result =  palindromes.OrderBy(x => x);
            Console.WriteLine(string.Join(", ",result));
        }
    }
}
