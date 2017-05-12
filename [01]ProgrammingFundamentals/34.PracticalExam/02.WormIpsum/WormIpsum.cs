namespace _02.WormIpsum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace Worm_Ipsum
    {
        public class WormIpsum
        {
            public static void Main()
            {
                while (true)
                {
                    string inputLine = Console.ReadLine();

                    if (inputLine == "Worm Ipsum")
                        break;

                    string[] inputParams = inputLine.Split(new[] { ". " }, StringSplitOptions.RemoveEmptyEntries);

                    char firstCharacter = inputParams[0].ToCharArray().ElementAt(0);
                    bool isLower = char.IsLower(firstCharacter);

                    if (inputParams.Length > 1 || isLower)
                        continue;

                    string[] sentence = inputParams[0].Split(" .".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < sentence.Length; i++)
                    {
                        char[] characters = sentence[i].ToCharArray();
                        Dictionary<char, int> counts = new Dictionary<char, int>();

                        foreach (var character in characters)
                        {
                            if (!counts.ContainsKey(character))
                                counts[character] = 0;

                            counts[character]++;
                        }

                        IOrderedEnumerable<KeyValuePair<char, int>> orderedCounts = counts.OrderByDescending(x => x.Value);
                        char element = orderedCounts.First().Key;
                        int count = orderedCounts.First().Value;

                        if (count > 1)
                        {
                            if (sentence[i].Contains(","))
                                sentence[i] = new string(element, sentence[i].Length - 1) + ",";
                            else
                                sentence[i] = new string(element, sentence[i].Length);
                        }
                    }

                    Console.WriteLine(string.Join(" ", sentence) + ".");
                }
            }
        }
    }
}
