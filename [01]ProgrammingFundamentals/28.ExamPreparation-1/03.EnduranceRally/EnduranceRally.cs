namespace _03.EnduranceRally
{
    using System;
    using System.Linq;

    public class EnduranceRally
    {
        public static void Main()
        {
            var participants = Console.ReadLine().Split();
            var trackLayout = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            var checkpointIndexes = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (var participant in participants)
            {
                double startingFuel = participant[0];

                for (int currentZoneIndex = 0; currentZoneIndex <= trackLayout.Length; currentZoneIndex++)
                {
                    var outOfFuel = startingFuel < 1;
                    var reachedTheEnd = currentZoneIndex == trackLayout.Length;
                    var raceHasEnded = outOfFuel || reachedTheEnd;

                    if (raceHasEnded)
                    {
                        if (outOfFuel)
                        {
                            Console.WriteLine($"{participant} - reached {currentZoneIndex - 1}");
                        }

                        else if (reachedTheEnd)
                        {
                            Console.WriteLine($"{participant} - fuel left {startingFuel:f2}");
                        }

                        break;
                    }

                    var checkpointFuel = trackLayout[currentZoneIndex];
                    var isCheckpoint = checkpointIndexes.Contains(currentZoneIndex);

                    if (isCheckpoint)
                    {
                        startingFuel += checkpointFuel;
                    }
                    else
                    {
                        startingFuel -= checkpointFuel;
                    }
                }
            }
        }
    }
}
