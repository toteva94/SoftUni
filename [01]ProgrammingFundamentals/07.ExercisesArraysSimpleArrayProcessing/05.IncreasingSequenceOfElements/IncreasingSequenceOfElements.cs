namespace _05.IncreasingSequenceOfElements
{
    using System;
    using System.Linq;

   public class IncreasingSequenceOfElements
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var currentElement = numbers[0];
            var increased = false;
            var decreased = false;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    decreased = true;
                }
                else
                {
                    increased = true;
                }
            }

            if (decreased)
                Console.WriteLine("No");
            else
                Console.WriteLine("Yes");

        }
    }
}
