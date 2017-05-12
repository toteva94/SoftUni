namespace _03.FootballLeague
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Score
    {
        public int Goals { get; set; }

        public int Points { get; set; }
    }
    public class FootballLeague
    {
        public static void Main()
        {
            var key = Regex.Escape(Console.ReadLine());

            var pattern = $@"^.*(?:{key})(?<team1>[a-zA-z]*)(?:{key}).* .*(?:{key})(?<team2>[a-zA-z]*)(?:{key}).* (?<team1Score>\d):(?<team2Score>\d).*$";

            var pointsTable = new Dictionary<string, Score>();

            var input = Console.ReadLine();

            while (input != "final")
            {
                var match = Regex.Match(input, pattern);

                if (!match.Success)
                {
                    input = Console.ReadLine();
                    continue;
                }

                var firstTeamName = new string(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                var secondTeamName = new string(match.Groups["team2"].Value.ToUpper().Reverse().ToArray());
                var firstTeamScore = int.Parse(match.Groups["team1Score"].Value);
                var secondTeamScore = int.Parse(match.Groups["team2Score"].Value);

                if (!pointsTable.ContainsKey(firstTeamName))
                {
                    pointsTable[firstTeamName] = new Score();
                }

                if (!pointsTable.ContainsKey(secondTeamName))
                {
                    pointsTable[secondTeamName] = new Score();
                }

                if (firstTeamScore > secondTeamScore)
                {
                    pointsTable[firstTeamName].Points += 3;
                }
                else if (firstTeamScore == secondTeamScore)
                {
                    pointsTable[firstTeamName].Points++;
                    pointsTable[secondTeamName].Points++;
                }
                else
                {
                    pointsTable[secondTeamName].Points += 3;
                }

                pointsTable[firstTeamName].Goals += firstTeamScore;
                pointsTable[secondTeamName].Goals += secondTeamScore;

                input = Console.ReadLine();
            }

            var sortedPointsTable = pointsTable.OrderByDescending(x => x.Value.Points).ThenBy(x => x.Key);
            var top3Teams = pointsTable.OrderByDescending(x => x.Value.Goals).Take(3);
            var place = 1;

            Console.WriteLine("League standings:");
            foreach (var team in sortedPointsTable)
            {
                Console.WriteLine($"{place++}. {team.Key} {team.Value.Points}");
            }

            Console.WriteLine("Top 3 scored goals:");
            foreach (var team in top3Teams)
            {
                Console.WriteLine($"- {team.Key} -> {team.Value.Goals}");
            }
        }
    }
}
