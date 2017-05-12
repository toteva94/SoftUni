namespace _04.ArrayHistogram
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayHistogram
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var listCount = new List<int>();
            var listWords = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                var currentWord = input[i];

                if (listWords.Contains(currentWord))
                {
                    var wordIndex = listWords.IndexOf(currentWord);
                    listCount[wordIndex]++;
                }
                else
                {
                    listWords.Add(currentWord);
                    listCount.Add(1);
                }
            }

            var swapped = true;

            while (swapped)
            {
                swapped = false;

                for (int i = 0; i < listCount.Count - 1; i++)
                {
                    if (listCount[i] < listCount[i + 1])
                    {
                        var tempInt = listCount[i];
                        listCount[i] = listCount[i + 1];
                        listCount[i + 1] = tempInt;

                        var tempString = listWords[i];
                        listWords[i] = listWords[i + 1];
                        listWords[i + 1] = tempString;

                        swapped = true;
                    }
                }
            }

            for (int i = 0; i < listWords.Count; i++)
            {
                var currentPercentage = (listCount[i] * 100.0) / input.Count;
                Console.WriteLine($"{listWords[i]} -> {listCount[i]} times ({currentPercentage:f2}%)");
            }
        }
    }
}

