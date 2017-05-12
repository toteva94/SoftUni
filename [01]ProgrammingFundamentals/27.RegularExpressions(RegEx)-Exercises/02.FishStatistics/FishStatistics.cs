namespace _02.FishStatistics
{
    using System;
    using System.Text.RegularExpressions;

    public class FishStatistics
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var pattern = @"([>]+)?<([(]+)(['x-])>";
            var regex = new Regex(pattern);
            var matches = regex.Matches(input);

            var tailLength = 0;
            var bodyLength = 0;
            var tailType = string.Empty;
            var bodyType = string.Empty;
            var status = string.Empty;
            var fishCount = 1;
            if (matches.Count > 0)
            {
                foreach (Match fish in matches)
                {
                    var tailLengthData = fish.Groups[1].Length;
                    var bodyLengthData = fish.Groups[2].Length;
                    var statusData = fish.Groups[3].Value;


                    if (tailLengthData > 5)
                    {
                        tailLength = tailLengthData * 2;
                        tailType = "Long";
                    }
                    else if (tailLengthData > 1)
                    {
                        tailLength = tailLengthData * 2;
                        tailType = "Medium";
                    }
                    else if (tailLengthData == 1)
                    {
                        tailLength = tailLengthData * 2;
                        tailType = "Short";
                    }
                    else
                    {
                        tailLength = 0;
                        tailType = "None";
                    }

                    if (bodyLengthData > 10)
                    {
                        bodyLength = bodyLengthData * 2;
                        bodyType = "Long";
                    }
                    else if (bodyLengthData > 5)
                    {
                        bodyLength = bodyLengthData * 2;
                        bodyType = "Medium";
                    }
                    else
                    {
                        bodyLength = bodyLengthData * 2;
                        bodyType = "Short";
                    }

                    if (statusData == "'")
                    {
                        status = "Awake";
                    }
                    else if (statusData == "-")
                    {
                        status = "Asleep";
                    }
                    else
                    {
                        status = "Dead";
                    }

                    Console.WriteLine($"Fish {fishCount}: {fish.Value}");
                    if (tailLength > 0)
                    {
                        Console.WriteLine($"    Tail type: {tailType} ({tailLength} cm)");
                    }
                    else
                    {
                        Console.WriteLine($"    Tail type: {tailType}");
                    }
                    if (bodyLength > 0)
                    {
                        Console.WriteLine($"    Body type: {bodyType} ({bodyLength} cm)");
                    }
                    else
                    {
                        Console.WriteLine($"    Body type: {bodyType}");
                    }
                    Console.WriteLine($"    Status: {status}");

                    fishCount++;
                }
            }
            else
            {
                Console.WriteLine("No fish found.");
            }


        }
    }
}
