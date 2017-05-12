namespace _4.RotateArrayOfStrings
{
    using System;
    using System.Linq;

    public class RotateArrayOfStrings
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToArray();

             var result = new string[words.Length];
            

            for (int i = 0; i < words.Length - 1; i++)
            {
                result[i + 1] = words[i]; 
            }

            var lastElement = words[result.Length - 1];
            result[0] = lastElement;

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
