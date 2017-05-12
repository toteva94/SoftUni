namespace _06.Messages
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class User
    {
        public string Username { get; set; }

        public List<Message> ReceivedMessages { get; set; }
    }

    public class Message
    {
        public string Content { get; set; }

        public User Sender { get; set; }
    }
    public class Messages
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var users = new List<User>();

            while (input != "exit")
            {
                var elements = input
                    .Split()
                    .ToArray();

                var firstElement = elements[0];

                if (firstElement == "register")
                {
                    var username = elements[1];
                    var currentUser = new User
                    {
                        Username = username,
                        ReceivedMessages = new List<Message>()
                    };


                    if (!users.Contains(currentUser))
                    {
                        users.Add(currentUser);
                    }
                }
                else
                {
                    var sender = elements[0];
                    var command = elements[1];
                    var recipient = elements[2];

                    var currentMessage = new Message();
                    currentMessage.Content = elements[3];
                    currentMessage.Sender = new User() { Username = sender, ReceivedMessages = new List<Message>() };

                    var ifContainsSender = users
                        .Where(x => x.Username == sender).ToArray();
                    var ifContainsRecipient = users
                        .Where(x => x.Username == recipient).ToArray();

                    if (ifContainsSender.Count() > 0 && ifContainsRecipient.Count() > 0)
                    {
                        var recipientMessages = users
                            .FirstOrDefault(x => x.Username == recipient);
                        if (recipientMessages != null)
                        {
                            recipientMessages
                                .ReceivedMessages
                                .Add(currentMessage);
                        }
                    }
                }
                input = Console.ReadLine();
            }

            var usernames = Console.ReadLine()
                .Split()
                .ToArray();

            var firstUser = usernames[0];
            var secondUser = usernames[1];

            var messagesFromFirstToSecond = users
                .Where(x => x.Username == secondUser)
                .SelectMany(x => x.ReceivedMessages)
                .Where(x => x.Sender.Username == firstUser)
                .Count();
            var messagesFromSecondToFirst = users
                .Where(x => x.Username == firstUser)
                .SelectMany(x => x.ReceivedMessages)
                .Where(x => x.Sender.Username == secondUser)
                .Count();

            if (messagesFromFirstToSecond == 0 && messagesFromSecondToFirst == 0)
            {
                Console.WriteLine("No messages");

            }
            else
            {
                for (int i = 0; i < Math.Max(messagesFromFirstToSecond, messagesFromSecondToFirst); i++)
                {


                    if (i < messagesFromFirstToSecond)
                    {
                        Console.WriteLine($"{firstUser}: {users.Where(x => x.Username == secondUser).SelectMany(x => x.ReceivedMessages).Where(x => x.Sender.Username == firstUser).Select(x => x.Content).ToList()[i]}");
                    }
                    if (i < messagesFromSecondToFirst)
                    {
                        Console.WriteLine($"{users.Where(x => x.Username == firstUser).SelectMany(x => x.ReceivedMessages).Where(x => x.Sender.Username == secondUser).Select(x => x.Content).ToList()[i]} :{secondUser}");
                    }

                }
            }
        }

    }
}

