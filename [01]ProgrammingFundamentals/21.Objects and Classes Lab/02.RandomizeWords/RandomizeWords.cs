namespace _02.RandomizeWords
{
    using System;
    using System.Linq;

    public class RandomizeWords
    {
       public static void Main()
        {
            var words = Console.ReadLine().Split().ToArray();
            var random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomPosition = random.Next(0,words.Length);

                var temporaryWord = words[randomPosition];
                words[randomPosition] = currentWord;
                words[i] = temporaryWord;
            }

            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
