namespace _03.StringRepeater
{
    using System;

    class StringRepeater
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var count = int.Parse(Console.ReadLine());

            var result = RepeatString(inputString, count);

            Console.WriteLine(result);
        }

        static string RepeatString(string str, int count)
        {
            string repeatedString = string.Empty;

            for (int i = 0; i < count; i++)
            {
                repeatedString += str;
            }

            return repeatedString;
        }

    }
}
