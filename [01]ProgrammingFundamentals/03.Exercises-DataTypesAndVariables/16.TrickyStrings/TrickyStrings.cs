namespace _16.TrickyStrings
{
    using System;
  
    public class TrickyStrings
    {
       public static void Main(string[] args)
        {
            var delimiter = Console.ReadLine();
            var maxWords = int.Parse(Console.ReadLine());
            var text = string.Empty;
            for (int i = 0; i < maxWords; i++)
            {
                var words = Console.ReadLine();
                text += words + delimiter;
            }

            string removeLastChar = text.Remove(text.Length - delimiter.Length, delimiter.Length);
            Console.Write(removeLastChar);
            Console.WriteLine();
        }
    }
}
