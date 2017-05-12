namespace _01.MelrahShake
{
    using System;
    using System.Text.RegularExpressions;

    public class MelrahShake
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var pattern = Console.ReadLine();

            var regex = new Regex(Regex.Escape(pattern));

            var matches = regex.Matches(input);

            while (true)
            {
                if (matches.Count >= 2 && pattern.Length > 0)
                {
                    var startIndex = input.IndexOf(pattern);
                    var lastIndex = input.LastIndexOf(pattern);

                    input = input.Remove(lastIndex, pattern.Length);
                    input = input.Remove(startIndex, pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);

                    Console.WriteLine("Shake it!");
                }
                else
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                regex = new Regex(Regex.Escape(pattern));
                matches = regex.Matches(input);
            }

            Console.WriteLine(input);
        }
    }
}
