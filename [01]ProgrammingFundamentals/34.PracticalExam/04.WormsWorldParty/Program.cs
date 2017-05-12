using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.WormsWorldParty
{
    public class Worm
    {
        public string Name { get; set; }

        public string TeamName { get; set; }

        public long Score { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var wormsPartyData = new Dictionary<string, List<Worm>>();
            var uniqueWorms = new List<string>();

            while (input != "quit")
            {
                var inputParams = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var item in inputParams)
                {
                    var currentWorm = new Worm
                    {
                        Name = inputParams[0].Trim(),
                        TeamName = inputParams[1].Trim(),
                        Score = long.Parse(inputParams[2].Trim())
                    };

                    if (uniqueWorms.Contains(currentWorm.Name))
                    {
                       continue;
                    }

                    uniqueWorms.Add(currentWorm.Name);

                    if (!wormsPartyData.ContainsKey(currentWorm.TeamName))
                    {
                        wormsPartyData[currentWorm.TeamName] = new List<Worm>();
                    }

                    wormsPartyData[currentWorm.TeamName].Add(currentWorm);
                }

                input = Console.ReadLine();
            }

            var count = 0;

            var sortedWormsPartyData = wormsPartyData
                .OrderByDescending(x => x.Value.Sum(y => y.Score))
                .ThenByDescending(x => x.Value.Average(y => y.Score));

            foreach (var team in sortedWormsPartyData)
            {
                var teamName = team.Key;
                var totalScore = team.Value.Sum(x => x.Score);

                Console.WriteLine($"{count++}. Team: {teamName} - {totalScore}");

                foreach (var worm in team.Value.OrderByDescending(x => x.Score))
                {
                    var wormName = worm.Name;
                    var wormScore = worm.Score;

                    Console.WriteLine($"###{wormName} : {wormScore}");
                }

            }
        }
    }
}
