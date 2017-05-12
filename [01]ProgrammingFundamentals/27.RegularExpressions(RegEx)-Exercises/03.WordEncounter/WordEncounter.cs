namespace _03.WordEncounter
{
    using System;
    using System.Text.RegularExpressions;

    public class WordEncounter
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var happyPattern = @"(:\))|(:D)|(;\))|(:\*)|(:\])|(;\])|(:\})|(;\})|(\(:)|(\*:)|(c:)|(\[:)|(\[;)";
            var sadPattern = @"[:;)\]D][(:\[\{c;]";

            var happyRegex = new Regex(happyPattern);
            var sadRegex = new Regex(sadPattern);

            var happyMatches = happyRegex.Matches(input);
            var sadMatches = sadRegex.Matches(input);

            var happyCount = happyMatches.Count;
            var sadCount = sadMatches.Count;

            var happinessIndex = happyCount / (double)sadCount;


            if (happinessIndex >= 2)
            {
                Console.WriteLine($"Happiness index: {happinessIndex:f2} :D");
                Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
            }
            else if (happinessIndex > 1)
            {
                Console.WriteLine($"Happiness index: {happinessIndex:f2} :)");
                Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
            }
            else if (happinessIndex == 1)
            {
                Console.WriteLine($"Happiness index: {happinessIndex:f2} :|");
                Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
            }
            else if (happinessIndex < 1)
            {
                Console.WriteLine($"Happiness index: {happinessIndex:f2} :(");
                Console.WriteLine($"[Happy count: {happyCount}, Sad count: {sadCount}]");
            }
        }
    }
}
