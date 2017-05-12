namespace _04.HornetArmada
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HornetArmada
    {
        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            var legionActivity = new Dictionary<string, long>();
            var soldiersData = new Dictionary<string,Dictionary<string,long>>();
            // 1 = BlackBeatles -> Soldier:2000 {lastActivity} = {legionName} -> {soldierType}:{soldierCount}
            for (int i = 0; i < count; i++)
            {
                var armyData = Console.ReadLine()
                    .Split(new[] { ' ', '-', '>', '=', ':' }, StringSplitOptions.RemoveEmptyEntries);

                var lastActivity = long.Parse(armyData[0]);
                var legionName = armyData[1];
                var soldierType = armyData[2];
                var soldierCount = long.Parse(armyData[3]);

                if (!legionActivity.ContainsKey(legionName))
                {
                    legionActivity[legionName] = lastActivity;
                    soldiersData[legionName] = new Dictionary<string, long>();
                }

                if (lastActivity > legionActivity[legionName])
                {
                    legionActivity[legionName] = lastActivity;
                }

                if (!soldiersData[legionName].ContainsKey(soldierType))
                {
                    soldiersData[legionName].Add(soldierType, 0);
                }

                soldiersData[legionName][soldierType] += soldierCount;
            }

            var query = Console.ReadLine().Split('\\');

            if(query.Length > 1)
            {
                var activity = int.Parse(query[0]);
                var soldierType = query[1];

                foreach (var soldierEntry in soldiersData
                    .Where(legion => legion.Value.ContainsKey(soldierType))
                    .OrderByDescending(legion => legion.Value[soldierType]))
                {
                    
                    if (legionActivity[soldierEntry.Key] < activity)
                    {
                        Console.WriteLine($"{soldierEntry.Key} -> {soldiersData[soldierEntry.Key][soldierType]}");
                    }
                }
            }
            else
            {
                var soldierType = query[0];
                
                foreach (var legionEntry in legionActivity.OrderByDescending(legion => legion.Value))
                {
                    if (soldiersData[legionEntry.Key].ContainsKey(soldierType))
                    {
                        Console.WriteLine($"{legionEntry.Value} : {legionEntry.Key}");
                    }
                }
            }
        }
    }
}
