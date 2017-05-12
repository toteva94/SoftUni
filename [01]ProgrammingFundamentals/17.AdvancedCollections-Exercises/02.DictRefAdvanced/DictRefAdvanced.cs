namespace _02.DictRefAdvanced
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DictRefAdvanced
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var personsData = new Dictionary<string, List<int>>();

            while (input != "end")
            {
                var elements = input.Split(new char[] { ' ', '-', '>', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var name = elements[0];

                var number = 0;

                if (int.TryParse(elements[1], out number))
                {
                  if (!personsData.ContainsKey(name))
                        personsData[name] = new List<int>();

                    for (int i = 1; i < elements.Length; i++)
                    {
                        personsData[name].Add(int.Parse(elements[i]));
                    }
                    
                }
                else
                {
                    var anotherName = elements[1];
                    if (personsData.ContainsKey(anotherName))
                        personsData[name] = new List<int>(personsData[anotherName]);
                }

                input = Console.ReadLine();
            }


            foreach (var pair in personsData)
            {
                var person = pair.Key;
                var value = pair.Value;

                Console.WriteLine($"{person} === {string.Join(", ", value)}");
            }

        }
    }
}
