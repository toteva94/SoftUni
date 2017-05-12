namespace _01.Wormtest
{
    using System;


    public class Program
    {
        public static void Main()
        {
            var lengthInM = int.Parse(Console.ReadLine());
            var width = decimal.Parse(Console.ReadLine());

            var lengthInCm = lengthInM * 100;
            var reminder = 0M;
            try
            {
                reminder = lengthInCm % width;
            }
            catch
            {
                reminder = 0;
            }

            
            if (reminder <= 0)
            {
                Console.WriteLine($"{lengthInCm * width:F2}");
            }
            else
            {
                var persentage = Math.Round((lengthInCm / width) * 100, 2);
                Console.WriteLine($"{persentage}%");
            }
        }
    }
}
