namespace _03.RecordUniqueNames
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RecordUniqueNames
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var uniqueNames = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                uniqueNames.Add(input);
            }

            foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }
            
        }
    }
}
