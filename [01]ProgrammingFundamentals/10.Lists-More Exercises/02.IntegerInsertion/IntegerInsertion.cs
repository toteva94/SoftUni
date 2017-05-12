namespace _02.IntegerInsertion
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IntegerInsertion
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            var input = Console.ReadLine();

            while (input != "end")
            {
                var parsedInput = int.Parse(input);

                for (int i = 0; i < numbers.Count; i++)
                {
                    int numberToInsert = parsedInput;
                    var firstDigit = GetFirstDigit(numberToInsert);

                    if (firstDigit == i)
                    {
                        numbers.Insert(i, numberToInsert);
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }

        public static int GetFirstDigit(int number)
        {
            number = Math.Abs(number);
            while (number >= 10)
                number /= 10;
            return number;
        }
    }
}
