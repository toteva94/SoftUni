namespace _02.OddOccurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class OddOccurrences
    {
        public static void Main()
        {
            var words = Console.ReadLine().ToLower().Split().ToList();
            var counts = new Dictionary<string, int>();
            var result = new List<string>();

            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                    counts[word]++;
                else
                    counts[word] = 1;
            }

            foreach (var word in counts.Keys)
            {
                if(counts[word] % 2 != 0)
                {
                    result.Add(word);
                }
            }

            Console.WriteLine(string.Join(", ",result));
        }
    }
}
