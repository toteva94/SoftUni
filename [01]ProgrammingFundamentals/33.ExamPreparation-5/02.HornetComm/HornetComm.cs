namespace _02.HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public class HornetComm
    {
        public static void Main()
        {
            var broadcastData = new List<string>();
            var privateMessageData = new List<string>();

            var broadcastPattern = @"^(?<firstQuery>[\D]+) <-> (?<secondQuery>[a-zA-z0-9]+)$";
            var privateMessagePattern = @"^(?<firstQuery>\d+) <-> (?<secondQuery>[0-9a-zA-z]+)$";

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Hornet is Green")
                {
                    break;
                }

                var broadcastMatch = Regex.Match(input, broadcastPattern);
                var privateMessageMatch = Regex.Match(input, privateMessagePattern);

                if (!broadcastMatch.Success && !privateMessageMatch.Success)
                {
                    continue;
                }

                if (privateMessageMatch.Success)
                {
                    var recepientCode = privateMessageMatch.Groups["firstQuery"].Value;
                    var message = privateMessageMatch.Groups["secondQuery"].Value;

                    var reversedRecepientCode = new string(recepientCode.Reverse().ToArray());


                    privateMessageData.Add($"{reversedRecepientCode} -> {message}");
                }
                else if (broadcastMatch.Success)
                {
                    var message = broadcastMatch.Groups["firstQuery"].Value;
                    var frequency = broadcastMatch.Groups["secondQuery"].Value;

                    var changedFrequency = new StringBuilder();

                    for (int i = 0; i < frequency.Length; i++)
                    {
                        if (char.IsLower(frequency[i]))
                        {
                            changedFrequency.Append(char.ToUpper(frequency[i]));
                        }
                        else if (char.IsUpper(frequency[i]))
                        {
                            changedFrequency.Append(char.ToLower(frequency[i]));
                        }
                        else
                        {
                            changedFrequency.Append(frequency[i]);
                        }
                    }

                    broadcastData.Add($"{changedFrequency} -> {message}");
                }
            }

            Console.WriteLine("Broadcasts:");

            if (!broadcastData.Any())
            {
                Console.WriteLine("None");
            }
            else
            {
                foreach (var broadcast in broadcastData)
                {
                    Console.WriteLine(broadcast);
                }
            }

            Console.WriteLine("Messages:");

            if (!privateMessageData.Any())
            {
                Console.WriteLine("None");
            }
            else
            { 
            foreach (var message in privateMessageData)
            {
                Console.WriteLine(message);
            }
            }
        }
    }
}
