namespace _05.DecodeRadioFrequencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().ToList();
            var result = new List<char>();

            for (int i = 0; i < numbers.Count; i++)
            {
                string[] frequence = new string[2];
                frequence = numbers[i].Split('.');
                int leftPart = int.Parse(frequence[0]);
                int rightPart = int.Parse(frequence[1]);
                char leftChar = (char)leftPart;
                char RightChar = (char)rightPart;
                if (leftPart != 0)
                {
                    result.Insert(i, leftChar);
                }
                if (rightPart != 0)
                {
                    result.Insert(result.Count - i, RightChar);
                }
            }

            Console.WriteLine(string.Join("", result));




        }
    }
}
