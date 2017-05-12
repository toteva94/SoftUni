namespace _03.ForumTopics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class ForumTopics
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var topicsData = new Dictionary<string, HashSet<string>>();

            while (input != "filter")
            {
                var elements = input.Split(new char[] { ' ', ',', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var topic = elements[0];

                if (!topicsData.ContainsKey(topic))
                    topicsData[topic] = new HashSet<string>();

                for (int i = 1; i < elements.Length; i++)
                {

                    topicsData[topic].Add(elements[i]);
                }

                input = Console.ReadLine();
            }

            var hashtags = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var counter = 0;

            foreach (var pair in topicsData)
            {
                var topic = pair.Key;
                var topicsHashtags = pair.Value;

                foreach (var hashtag in hashtags)
                {
                    if (topicsHashtags.Contains(hashtag))
                        counter++;
                }

                if (hashtags.Length == counter)
                {

                    Console.WriteLine($"{topic} | #{string.Join(", #", topicsHashtags)}");
                }

                counter = 0;
            }


        }
    }
}
