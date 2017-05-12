namespace _01.Placeholders
{
    using System;

   public class Placeholders
    {
       public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var stringParts = input
                    .Split(new char[] { '-', '>', }, StringSplitOptions.RemoveEmptyEntries);

                var currentString = stringParts[0].Trim();
                var elements = stringParts[1]
                    .Trim()
                    .Split(new char[] {' ', ',' },StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < elements.Length; i++)
                {
                    var currentPlaceholder = "{" + i + "}";

                    currentString = currentString.Replace(currentPlaceholder, elements[i]);
                }

                Console.WriteLine(currentString);

                input = Console.ReadLine();
            }
        }
    }
}
