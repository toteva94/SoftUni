namespace _04.SentenceSplit
{
    using System;
    using System.Linq;

    public class SentenceSplit
    {
        public static void Main()
        {

            var sentence = Console.ReadLine(); 
            var delimiter = Console.ReadLine(); 

            Console.Write("[");
            Console.Write(string.Join(", ", sentence.Split(new[] { delimiter }, StringSplitOptions.None)));
            Console.WriteLine("]");
        }
    }
}
