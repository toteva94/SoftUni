using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09.UserLogs
{
    using System;

    public class UserLogs
    {
        public static void Main()
        {
            var userLogs = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "end")
                {
                    break;
                }

                var commands = input.Split();
                var IP = commands[0].Split(new[] { '=' }).Last();
                var message = commands[1].Split(new[] { '=' }).Last();
                var username = commands[2].Split(new[] { '=' }).Last();

                if (!userLogs.ContainsKey(username))
                {
                    userLogs[username] = new Dictionary<string, int>();
                }

                if (!userLogs[username].ContainsKey(IP))
                {
                    userLogs[username][IP] = 0;
                }

                userLogs[username][IP]++;

            }

            foreach (var kvp in userLogs.OrderBy(x => x.Key))
            {
                var username = kvp.Key;
                var ips = kvp.Value;
                Console.WriteLine($"{username}:");
                foreach (var ipAndCount in ips)
                {
                    Console.Write(ipAndCount.Key != kvp.Value.Keys.Last()
                        ? $"{ipAndCount.Key} => {ipAndCount.Value}, "
                        : $"{ipAndCount.Key} => {ipAndCount.Value}. ");
                }
                Console.WriteLine();
            }

           
        }
    }
}