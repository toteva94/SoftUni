namespace _04.NthDigit
{
    using System;

    class NthDigit
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());
            var indexToFound = int.Parse(Console.ReadLine());

            var result = FindNthDigit(number, indexToFound);
            Console.WriteLine(result);
        }

        static int FindNthDigit(long num, int index)
        {
            var currentIndex = 1;

            while (num > 0)
            {
                if (currentIndex == index)
                {
                    return (int)(num % 10);
                }

                currentIndex++; 
                num /= 10;
            }

            return (int)(num % 10);
        }
    }
}
