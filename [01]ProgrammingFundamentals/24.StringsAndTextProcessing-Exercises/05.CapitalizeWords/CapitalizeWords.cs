namespace _05.CapitalizeWords
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;


    public class CapitalizeWords
    {
        public static void Main()
        {
            var result = new List<string>();
            var sentenceList = new List<string>();
            var input = Console.ReadLine();

            while (input != "end")
            {
                input = System
                    .Threading
                    .Thread
                    .CurrentThread
                    .CurrentCulture
                    .TextInfo
                    .ToTitleCase(input.ToLower());

                var sentence = input.Split(new[] { ',', ' ', '=', '-', '>', ':', '~', '}', '|', '{', '`', '^', ']', '\\', '[', '?', '<', ';', '/', '.', '+', '*', ')', '(', '&', '%', '$', '#', '\"', '!' },StringSplitOptions.RemoveEmptyEntries).ToArray();
               
                foreach (var word in sentence)
                {
                    result.Add(word);
                }

                Console.WriteLine(string.Join(", ", result));

                result.Clear();

                input = Console.ReadLine();
            }

           
        }
    }
}
