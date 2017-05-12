namespace _1.SpecialNumbers
{
    using System;

    public class SpecialNumbers
    {
        public static void Main(string[] args)
        {
            var maxNumber = int.Parse(Console.ReadLine());

            for (int num = 1; num <= maxNumber; num++)
            {
                var sum = 0;
                var digit = num;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit /= 10;
                }

                var result = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{num} -> {result}");
            }
        }
    }
}
