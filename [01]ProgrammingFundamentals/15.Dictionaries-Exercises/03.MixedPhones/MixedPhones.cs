namespace _03.MixedPhones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MixedPhones
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var phonebook = new SortedDictionary<string, long>();

            while (input != "Over")
            {
                var elements = input.Split(new char[] { ' ', ':' }, StringSplitOptions.RemoveEmptyEntries);
                var name = elements[0];
                var phoneNumber = elements[1];

                long number = 0;
                if (long.TryParse(name, out number))
                {
                    phonebook[phoneNumber] = number;
                }
                else if (long.TryParse(phoneNumber, out number))
                {
                    phonebook[name] = number;
                }

                input = Console.ReadLine();
            }

            foreach (var person in phonebook.Keys)
            {
                Console.WriteLine($"{person} -> {phonebook[person]}");
            }
        }
    }
}
