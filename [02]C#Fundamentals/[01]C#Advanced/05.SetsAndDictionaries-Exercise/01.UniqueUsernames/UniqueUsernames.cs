namespace _01.UniqueUsernames
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    public class UniqueUsernames
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            var names = new HashSet<string>();

            for (var i = 0; i < count; i++)
            {
                var currentName = Console.ReadLine();
                names.Add(currentName);
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}