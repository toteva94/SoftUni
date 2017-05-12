namespace _7.GreaterOfTwoValues
{
    using System;

    public class GreaterOfTwoValues
    {
        public static void Main(string[] args)
        {
            var dataType = Console.ReadLine();

            switch (dataType)
            {
                case "int":
                    {
                        var firstInt = int.Parse(Console.ReadLine());
                        var secondInt = int.Parse(Console.ReadLine());
                        var maxInt = GetMax(firstInt,secondInt);
                        Console.WriteLine(maxInt);
                        break;
                    }
                case "char":
                    {
                        var firstChar = char.Parse(Console.ReadLine());
                        var secondChar = char.Parse(Console.ReadLine());
                        var maxChar = GetMax(firstChar,secondChar);
                        Console.WriteLine(maxChar);
                        break;
                    }
                default:
                    {
                        var firstString = Console.ReadLine();
                        var secondString = Console.ReadLine();
                        var maxString = GetMax(firstString,secondString);
                        Console.WriteLine(maxString);
                        break;
                    }
                   
            }
        }

        public static int GetMax(int num1, int num2)
        {
            if (num1 > num2)
                return num1;
            return num2;
        }
        public static char GetMax(char char1, char char2)
        {
            if ((int)char1 > (int)char2)
                return char1;
            return char2;
        }
        public static string GetMax(string string1, string string2)
        {
            if (string1.CompareTo(string2) >= 0)
                return string1;
            return string2;
        }
    }
}
