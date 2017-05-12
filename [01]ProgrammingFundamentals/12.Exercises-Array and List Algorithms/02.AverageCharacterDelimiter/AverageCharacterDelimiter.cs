namespace _02.AverageCharacterDelimiter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class AverageCharacterDelimiter
    {
        public static void Main()
        {
           // var input = Console.ReadLine().Split().ToList();
            //var charArrayList = input.Select(str => str.ToCharArray()).ToList();
           // var numList = new List<int>();
           // for (int i = 0; i < charArrayList.Count; i++)
           // {
                //numList.Add(Convert.ToInt32(charArrayList[i]));
            //}

            //.WriteLine(string.Join(" ", numList));
            // var list = new List<int>();
            // var chars = new List<char>();
            // for (int i = 0; i < input.Count; i++)
            // {
            //     var convertToChar = (char)(input[i]);
            //     chars.Add(convertToChar);
            // }
            //
            // Console.WriteLine(string.Join(" ",chars));

            List<string> input = Console.ReadLine().Split(' ').ToList();
            double sumOfChars = 0;
            int numbersOfChars = 0;

            for (int i = 0; i < input.Count; i++)
            {
                numbersOfChars += input[i].Count();
                double sumOfElement = 0;
                foreach (var element in input[i])
                {
                    sumOfElement += (double)element;
                }
                sumOfChars += sumOfElement;
            }
            double averageSum = sumOfChars / numbersOfChars;
            if (averageSum >= 97 && averageSum <= 122)
            {
                averageSum -= 32;
            }

            char delimeter = (char)(averageSum);
            Console.WriteLine(string.Join(delimeter.ToString(), input));
        }
    }
}
