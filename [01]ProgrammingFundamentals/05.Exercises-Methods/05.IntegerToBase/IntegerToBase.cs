namespace _05.IntegerToBase
{
    using System;
   
   public class IntegerToBase
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var toBase = int.Parse(Console.ReadLine());

            var converted = GetIntegerToBase(number, toBase);

            Console.WriteLine(converted);
        }

        private static string GetIntegerToBase(int num, int toBase)
        {
            var result = string.Empty;

            while (num > 0)
            {
                var reminder = num % toBase;
                result = reminder + result;
                num /= toBase;
            }

            return result;
        }
    }
}
