namespace _7.FromTerabytesToBits
{
    using System;
    using System.Numerics;
    public class FromTerabytesToBits
    {
        public static void Main(string[] args)
        {
            var bits = decimal.Parse(Console.ReadLine());
            decimal terabytes = (1024M * 1024M * 1024M * 1024M * 8M) * bits;

            Console.WriteLine(Math.Round(terabytes));
        }
    }
}
