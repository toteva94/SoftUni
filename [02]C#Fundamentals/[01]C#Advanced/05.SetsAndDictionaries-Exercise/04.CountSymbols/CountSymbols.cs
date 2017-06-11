namespace _04.CountSymbols
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    public class CountSymbols
    {
        public static void Main(string[] args)
        {
            var charCounts = new SortedDictionary<char,int>();

            var text = Console.ReadLine();

            foreach (var chr in text)
            {
                if (!charCounts.ContainsKey(chr))
                {
                    charCounts[chr] = 0;
                }

                charCounts[chr]++;
            }

            foreach (var charCount in charCounts)
            {
                Console.WriteLine($"{charCount.Key}: {charCount.Value} time/s");
            }
        }
    }
}