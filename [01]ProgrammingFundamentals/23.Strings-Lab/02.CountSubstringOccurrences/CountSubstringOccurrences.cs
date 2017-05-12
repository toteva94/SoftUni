namespace _02.CountSubstringOccurrences
{
    using System;

    public class CountSubstringOccurrences
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var searchString = Console.ReadLine().ToLower();
            var index = text.IndexOf(searchString);
            var count = 0;

            while(index != -1)
            {
                count++;
                index = text.IndexOf(searchString, index + 1);
            }

            Console.WriteLine(count);
        }
    }
}
