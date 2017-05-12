namespace _01.Cards
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;

    public class Cards
    {
        public static void Main()
        {
            var validCards = new List<string>();
            var cards = Console.ReadLine();
            var pattern = @"([1]?[0-9JQKA])([SHDC])";
            var regex = new Regex(pattern);
            var matches = regex.Matches(cards);

            foreach (Match match in matches)
            {
                int power = 0;

                if(int.TryParse(match.Groups[1].Value,out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }

                validCards.Add(match.Value);
            }



            Console.WriteLine(string.Join(", ",validCards));
        }
    }
}
