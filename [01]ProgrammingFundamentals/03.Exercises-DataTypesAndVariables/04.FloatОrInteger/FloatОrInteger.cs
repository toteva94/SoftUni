namespace _4.FloatОrInteger
{
    using System;

    public class FloatОrInteger
    {
        public static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());

            if(number % 10 == 0)
                Console.WriteLine(number);
            else
                Console.WriteLine(Math.Round(number));
        }
    }
}
