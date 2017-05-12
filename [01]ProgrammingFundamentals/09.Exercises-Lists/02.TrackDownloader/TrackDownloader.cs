namespace _02.TrackDownloader
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TrackDownloader
    {
        public static void Main()
        {
            var blacklistedWords = Console.ReadLine().Split(' ').ToList();

            var dowloadedTracks = new List<string>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var isInBlacklist = false;

                foreach (var blacklistedWord in blacklistedWords)
                {
                    if (line.Contains(blacklistedWord))
                    {
                        isInBlacklist = true;
                        break;
                    }
                }

                if (!isInBlacklist)
                {
                    dowloadedTracks.Add(line);
                }

                line = Console.ReadLine();

            }

            dowloadedTracks.Sort();

            foreach (var track in dowloadedTracks)
            {
                Console.WriteLine(track);
            }
        }
    }
}
