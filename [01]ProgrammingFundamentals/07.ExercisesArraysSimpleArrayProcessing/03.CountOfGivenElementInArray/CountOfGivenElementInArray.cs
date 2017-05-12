namespace _3.CountOfGivenElementInArray
{
    using System;
    using System.Linq;

    public class CountOfGivenElementInArray
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var givenElement = int.Parse(Console.ReadLine());

            var count = 0;

            foreach (var num in numbers)
            {
                if (num == givenElement)
                    count++;
            }

            Console.WriteLine(count);
        }
    }
}
