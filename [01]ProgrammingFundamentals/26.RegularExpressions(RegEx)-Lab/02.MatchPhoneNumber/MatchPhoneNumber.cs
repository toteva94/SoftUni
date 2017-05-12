namespace _02.MatchPhoneNumber
{
    using System;
    using System.Text.RegularExpressions;

   public class MatchPhoneNumber
    {
       public static void Main()
        {
            var pattern = @"\+359(\s|-)2\1\d{3}\1\d{4}\b";
            var text = "+359 2 222 2222, 359-2-222-2222, +359/2/222/2222, +359-2 222 2222,+359 2-222-2222, +359-2-222-222, +359-2-222-22222, +359-2-222-2222";
            var regex = new Regex(pattern);
            var matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match);
            }
            
        }
    }
}
