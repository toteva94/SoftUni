namespace _06.MathPower
{
    using System;

    public class MathPower
    {
        public static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            var raisedNumber = RaiseToPower(number, power);

            Console.WriteLine(raisedNumber);
        }

        private static object RaiseToPower(double num, int pow)
        {
            var result = Math.Pow(num, pow);
            return result;
        }
    }
}
