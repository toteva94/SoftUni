namespace _2.SignOfIntegerNumber
{
    using System;

    public class SignOfIntegerNumber
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            PrintTheSignOfInt(number);
        }

        public static void PrintTheSignOfInt(int n)
        {
            if(n < 0)
                Console.WriteLine($"The number {n} is negative.");
            else if (n > 0)
                Console.WriteLine($"The number {n} is positive.");
            else
                Console.WriteLine($"The number {n} is zero.");
        }
    }
}
