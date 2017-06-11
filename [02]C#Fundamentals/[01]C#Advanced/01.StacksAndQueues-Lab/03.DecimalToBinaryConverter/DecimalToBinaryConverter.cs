namespace _03.DecimalToBinaryConverter
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    public class DecimalToBinaryConverter
    {
        public static void Main()
        {
            var decimalNumber = int.Parse(Console.ReadLine());

            var binaryNumber = new Stack<int>();

            if (decimalNumber == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                while (decimalNumber > 0)
                {
                    var reminder = decimalNumber % 2;
                    binaryNumber.Push(reminder);
                    decimalNumber = decimalNumber / 2;
                }
            }

            while (binaryNumber.Count > 0)
            {
                Console.Write(binaryNumber.Pop());
            }

            Console.WriteLine();
        }
    }
}