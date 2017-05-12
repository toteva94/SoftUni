namespace _06.EqualSequenceOfElementsInArray
{
    using System;
    using System.Linq;

    class EqualSequenceOfElementsInArray
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var areEqual = false;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    areEqual = true;
                }
            }

            if (areEqual)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
