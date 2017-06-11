using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _05.Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            var phonebook = new Dictionary<string,string>();

            while (true)
            {
                var currentNameAndNumber = Console.ReadLine();

                if (currentNameAndNumber == "search")
                {
                    break;
                }

                var phonebookValidation = currentNameAndNumber
                    .Split(new[] {' ', '-'}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (phonebookValidation.Length != 2)
                {
                    break;
                }

                var currentName = phonebookValidation[0];
                var currentNumber = phonebookValidation[1];

                if (!phonebook.ContainsKey(currentName))
                {
                    phonebook[currentName] = string.Empty;
                }

                phonebook[currentName] = currentNumber;
            }

            while (true)
            {
                var currentName = Console.ReadLine();

                if (currentName == "stop")
                {
                    break;
                }

                Console.WriteLine(phonebook.ContainsKey(currentName)
                    ? $"{currentName} -> {phonebook[currentName]}"
                    : $"Contact {currentName} does not exist.");
            }
        }
    }
}