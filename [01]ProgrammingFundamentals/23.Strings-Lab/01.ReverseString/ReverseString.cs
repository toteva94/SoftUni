namespace _01.ReverseString
{
    using System;
    using System.Linq;

    public class ReverseString
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var toCharArray = input.ToCharArray();
            Array.Reverse(toCharArray);
            Console.WriteLine(toCharArray); 
        }
    }
}
