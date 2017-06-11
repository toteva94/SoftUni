namespace _03.GroupNumbers
{
    using System;
    using System.Linq;
    public class GroupNumbers
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var remaindersCount = 3;
            var devider = 3;

            var remainders = new int[remaindersCount][];

            var counter = new int[remaindersCount];

            foreach (var number in numbers)
            {
                var remainder = Math.Abs(number % devider);
                counter[remainder]++;
            }

            for (var i = 0; i < counter.Length; i++)
            {
                var currentCount = counter[i];
                remainders[i] = new int[currentCount];
            }

            var indexes = new int[remaindersCount];

            foreach (var currentNumber in numbers)
            {
                var remainder = Math.Abs(currentNumber % 3);

                remainders[remainder][indexes[remainder]] = currentNumber;
                indexes[remainder]++;
            }

            for (var rowIndex = 0; rowIndex < remainders.GetLength(0); rowIndex++)
            {
                foreach (var number in remainders[rowIndex])
                {
                    Console.Write($"{number} ");
                }

                Console.WriteLine();
            }
        }
    }
}
