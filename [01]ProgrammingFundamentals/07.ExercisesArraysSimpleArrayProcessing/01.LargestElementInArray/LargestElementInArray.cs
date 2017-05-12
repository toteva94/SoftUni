namespace _1.LargestElementInArray
{
    using System;
    using System.Linq;

    public class LargestElementInArray
    {
       public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                var elements = int.Parse(Console.ReadLine());

                numbers[i] += elements;
            }

            var maxElement = numbers.Max();

            Console.WriteLine(maxElement);
        }
    }
}
