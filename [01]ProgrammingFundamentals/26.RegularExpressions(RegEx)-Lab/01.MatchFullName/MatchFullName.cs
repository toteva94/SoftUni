namespace _01.MatchFullName
{
    using System;
    using System.Text.RegularExpressions;

   public class MatchFullName
    {
        public static void Main()
        {
            var pattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";
            var text = "ivan ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Ivan IvAnov, Ivan	Ivanov";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
