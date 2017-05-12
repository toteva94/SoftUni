﻿namespace _04.WinningTicket
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class WinningTicket
    {
        public static void Main()
        {
            var tickets = Console.ReadLine()
                .Split(',')
                .Select(t => t.Trim())
                .ToArray();

            var pattern = @"([$@^#])\1{5,}";
            var ticketRegex = new Regex(pattern);


            foreach (var ticket in tickets)
            {
                if(ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var leftHalf = ticket.Substring(0,ticket.Length/2);
                var rightHalf = ticket.Substring(ticket.Length/2);

                var leftMatch = ticketRegex.Match(leftHalf);
                var rightMatch = ticketRegex.Match(rightHalf);

                if (leftMatch.Success && rightMatch.Success)
                {
                    var winningSymbol = leftMatch.Value[0];
                    var shorterMatch = Math.Min(leftMatch.Length, rightMatch.Length);

                    var jackpot = string.Empty;

                    if (shorterMatch == 10)
                    {
                        jackpot = " Jackpot!";
                    }

                    Console.WriteLine($"ticket \"{ticket}\" - {shorterMatch}{winningSymbol}{jackpot}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
