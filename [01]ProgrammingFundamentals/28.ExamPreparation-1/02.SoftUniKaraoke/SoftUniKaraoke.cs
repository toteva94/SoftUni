namespace _02.SoftUniKaraoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SoftUniKaraoke
    {
        public static void Main()
        {

            var participants = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var availableSongs = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .ToArray();

            var line = Console.ReadLine();

            var participantAwards = new Dictionary<string, HashSet<string>>();

            while (line != "dawn")
            {
                var performingData = line
                    .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                var currentParticipant = performingData[0];
                var currentSong = performingData[1];
                var currentAward = performingData[2];

                if (participants.Contains(currentParticipant) && availableSongs.Contains(currentSong))
                {
                    if (!participantAwards.ContainsKey(currentParticipant))
                    {
                        participantAwards[currentParticipant] = new HashSet<string>();
                    }

                    participantAwards[currentParticipant].Add(currentAward);
                }

                line = Console.ReadLine();
            }

            if (!participantAwards.Any())
            {
                Console.WriteLine("No awards");
                return;
            }
            
            var sortedParticipantAwards = participantAwards
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            foreach (var participantAward in sortedParticipantAwards)
            {
                var participant = participantAward.Key;
                var awards = participantAward.Value;

                Console.WriteLine($"{participant}: {awards.Count} awards");

                foreach (var award in awards.OrderBy(x => x))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
}
