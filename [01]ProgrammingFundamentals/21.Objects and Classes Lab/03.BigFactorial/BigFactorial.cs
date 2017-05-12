namespace _03.BigFactorial
{
    using System;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
