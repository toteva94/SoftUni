namespace _01.LambadaExpressions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LambadaExpressions
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var selectorsData = new Dictionary<string, Dictionary<string, string>>();

            while (input != "lambada")
            {
                var elements = input
                    .Split(new char[] { ' ', '=', '.', '>' }, StringSplitOptions.RemoveEmptyEntries);

                if (elements[0] != "dance")
                {
                    var selector = elements[0];
                    var selectorObeject = elements[1];
                    var property = elements[2];

                    if (!selectorsData.ContainsKey(selector))
                        selectorsData[selector] = new Dictionary<string, string>();
                    selectorsData[selector][selectorObeject] = property;
                }
                else
                {
                    selectorsData = selectorsData
                        .ToDictionary(s => s.Key, s => s.Value
                        .ToDictionary(sO => sO.Key, sO => sO.Key + "." + sO.Value));
                }

                input = Console.ReadLine();
            }

            foreach (var selector in selectorsData)
            {
                foreach (var selectorObject in selector.Value)
                {
                    Console.WriteLine($"{selector.Key} => {selectorObject.Key}.{selectorObject.Value}");
                }
            }
        }
    }
}
