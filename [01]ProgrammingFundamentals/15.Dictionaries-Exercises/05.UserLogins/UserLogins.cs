namespace _05.UserLogins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UserLogins
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var usersLoginData = new Dictionary<string, string>();

            while (input != "login")
            {
                var elements = input.Split().ToList();
                var username = elements[0];
                var password = elements[elements.Count - 1];

                if (!usersLoginData.ContainsKey(username))
                {
                    usersLoginData.Add(username, password);
                }
                else
                {
                    usersLoginData[username] = password;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            var count = 0;

            while (input != "end")
            {
                var elements = input.Split().ToList();
                var username = elements[0];
                var password = elements[elements.Count - 1];

                if(usersLoginData.ContainsKey(username))
                {
                    if (usersLoginData[username] == password)
                    {
                        Console.WriteLine($"{username}: logged in successfully");
                    }
                    else
                    {
                        count++;
                        Console.WriteLine($"{username}: login failed");
                    }
                }
                else
                {
                    count++;
                    Console.WriteLine($"{username}: login failed");
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine($"unsuccessful login attempts: {count}");
        }
    }
}
