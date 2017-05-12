namespace _10.DataOverflow
{
    using System;

    public class DataOverflow
    {
        public static void Main(string[] args)
        {
            var num1 = decimal.Parse(Console.ReadLine());
            var num2 = decimal.Parse(Console.ReadLine());

            decimal smallerNumber = Math.Min(num1, num2);
            decimal biggerNumber = Math.Max(num1, num2);

            decimal overflows = 0;

            if (byte.MinValue <= biggerNumber && biggerNumber <= byte.MaxValue)
            {
                Console.WriteLine("bigger type: byte");
            }
            else if (ushort.MinValue <= biggerNumber && biggerNumber <= ushort.MaxValue)
            {

                Console.WriteLine("bigger type: ushort");
            }
            else if (uint.MinValue <= biggerNumber && biggerNumber <= uint.MaxValue)
            {
                Console.WriteLine("bigger type: uint");
            }
            else if (ulong.MinValue <= biggerNumber && biggerNumber <= ulong.MaxValue)
            {
                Console.WriteLine("bigger type: ulong");
            }
            if (byte.MinValue <= smallerNumber && smallerNumber <= byte.MaxValue)
            {
                Console.WriteLine("smaller type: byte");
                overflows = biggerNumber / byte.MaxValue;
                Console.WriteLine($"{biggerNumber} can overflow byte {Math.Round(overflows)} times");
            }
            else if (ushort.MinValue <= smallerNumber && smallerNumber <= ushort.MaxValue)
            {
                Console.WriteLine("smaller type: ushort");
                overflows = biggerNumber / ushort.MaxValue;
                Console.WriteLine($"{biggerNumber} can overflow ushort {Math.Round(overflows)} times");
            }
            else if (uint.MinValue <= smallerNumber && smallerNumber <= uint.MaxValue)
            {
                Console.WriteLine("smaller type: uint");
                overflows = biggerNumber / uint.MaxValue;
                Console.WriteLine($"{biggerNumber} can overflow uint {Math.Round((decimal)overflows)} times");
            }
            else if (ulong.MinValue <= smallerNumber && smallerNumber <= ulong.MaxValue)
            {
                Console.WriteLine("smaller type: ulong");
                overflows = biggerNumber / ulong.MaxValue;
                Console.WriteLine($"{biggerNumber} can overflow ulong {Math.Round((decimal)overflows)} times");
            }
        }
    }
}
