namespace _12.VariableInHexadecimalFormat
{
    using System;

    public class VariableInHexadecimalFormat
    {
        public static void Main(string[] args)
        {
            var hexadecimalNum = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(hexadecimalNum, 16));
        }
    }
}
