namespace _04.RoliTheCoder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Event
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public List<string> Participants { get; set; }
    }
    public class RoliTheCoder
    {
        public static void Main()
        {
            var eventsData = new Dictionary<int, Event>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Time for Code")
                {
                    break;
                }

                var eventParts = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var eventID = 0;

                if (!int.TryParse(eventParts[0], out eventID))
                {
                    continue;
                }

                var eventName = string.Empty;

                if (eventParts.Length > 1 && eventParts[1].StartsWith("#"))
                {
                    eventName = eventParts[1].Trim('#');
                }
                else
                {
                    continue;
                }

                var participants = new List<string>();


                if (eventParts.Length > 2 && eventParts.Skip(2).All(p => p.StartsWith("@")))
                {
                    var allParticipants = eventParts.Skip(2).ToList();

                    foreach (var participant in allParticipants)
                    {
                        if (!participants.Contains(participant))
                        {
                            participants.Add(participant);
                        }
                    }
                }

                participants.Sort();

                if (!eventsData.ContainsKey(eventID))
                {
                    eventsData[eventID] = new Event
                    {
                        ID = eventID,
                        Name = eventName,
                        Participants = participants
                    };
                }
                else
                {
                    if (eventsData[eventID].Name == eventName)
                    {
                        foreach (var participant in participants)
                        {
                            if (!eventsData[eventID].Participants.Contains(participant))
                            {
                                eventsData[eventID].Participants.Add(participant);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }

            }

            var sortedEvents = eventsData
                   .OrderByDescending(x => x.Value.Participants.Count())
                   .ThenBy(x => x.Value.Name)
                   .ToDictionary(x => x.Key, y => y.Value);

            foreach (var eventEntry in sortedEvents)
            {
                var currentEventID = eventEntry.Key;
                var currentEvent = eventEntry.Value;

                Console.WriteLine($"{currentEvent.Name} - {currentEvent.Participants.Count()}");

                foreach (var participant in currentEvent.Participants.OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
