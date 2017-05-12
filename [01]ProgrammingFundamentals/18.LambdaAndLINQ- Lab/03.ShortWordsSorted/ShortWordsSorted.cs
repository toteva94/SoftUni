namespace _03.ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ShortWordsSorted
    {
        static void Main()
        {
            var words = Console.ReadLine().ToLower().Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            words = words.Where(w => w.Length < 5).OrderBy(w => w).Distinct().ToList();

            Console.WriteLine(string.Join(", ",words));
        }
    }
}
