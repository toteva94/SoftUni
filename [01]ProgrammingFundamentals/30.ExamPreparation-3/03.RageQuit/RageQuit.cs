namespace _03.RageQuit
{
    using System;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.Linq;
    using System.Text;

    public class RageQuit
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"(\D+)(\d+)");
            var matches = regex.Matches(input);

            var result = new StringBuilder();


            foreach (Match match in matches)
            {
                var symbols = match.Groups[1].Value.ToUpper();
                var count = int.Parse(match.Groups[2].Value);

                result.Append(Repeat(symbols, count));
            }

            var uniqueSymbols = result.ToString().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {uniqueSymbols}");
            Console.WriteLine(result);
        }

        private static object Repeat(string symbols, int count)
        {
            var result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(symbols);
            }

            return result.ToString().ToUpper();
        }
    }
}
