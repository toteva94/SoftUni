namespace _14.ASCIIString
{
    using System;

    public class ASCIIString
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var text = string.Empty;
            var symbols = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int unicode = int.Parse(Console.ReadLine());
                char character = (char)unicode;
                symbols = character.ToString();
                text += symbols;

            }
            Console.Write(text);
            Console.WriteLine();
        }
    }
}
