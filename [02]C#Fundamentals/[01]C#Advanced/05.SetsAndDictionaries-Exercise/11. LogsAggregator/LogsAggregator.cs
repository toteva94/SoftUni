using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _11.LogsAggregator
{
    public class LogsAggregator
    {
        public static void Main()
        {
            var accessLogsData = new SortedDictionary<string, SortedDictionary<string, long>>();

            var count = int.Parse(Console.ReadLine());
            var increaseDuration = new List<long>();

            for (var i = 0; i < count; i++)
            {
                var accessLogs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var ip = accessLogs[0];
                var name = accessLogs[1];
                var duration = long.Parse(accessLogs[2]);



                if (!accessLogsData.ContainsKey(name))
                {
                    accessLogsData[name] = new SortedDictionary<string, long>();
                }

                increaseDuration.Add(duration);

                if (!accessLogsData[name].ContainsKey(ip))
                {
                    accessLogsData[name][ip] = 0;
                }

                accessLogsData[name][ip] += duration;
            }

            foreach (var user in accessLogsData.Keys)
            {
                Console.WriteLine($"{user}: {accessLogsData[user].Values.Sum()} [{string.Join(", ", accessLogsData[user].Keys.ToArray())}]");
            }
        }
    }
}