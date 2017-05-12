namespace _02.Dict_Ref
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DictRef
    {
        public static void Main()
        {
            var saveValues = new Dictionary<string, int>();
            var input = Console.ReadLine();

            while (input != "end")
            {
                var elements = input.Split();
                var name = elements[0];
                var value = elements[elements.Length - 1];

                var number = 0;
                if (int.TryParse(value, out number))
                {
                    saveValues[name] = number;
                }
                else
                {
                    if (saveValues.ContainsKey(value))
                    {
                        var referencedValue = saveValues[value];
                        saveValues[name] = referencedValue;
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var name in saveValues.Keys)
            {
                Console.WriteLine($"{name} === {saveValues[name]}");
            }
        }
    }
}
