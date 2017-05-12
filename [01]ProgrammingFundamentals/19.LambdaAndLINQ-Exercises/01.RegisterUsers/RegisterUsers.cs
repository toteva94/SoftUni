namespace _01.RegisterUsers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RegisterUsers
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var lastFiveUsers = new Dictionary<string, DateTime>();
            var usersDictionary = new Dictionary<string, DateTime>();

            while (input != "end")
            {
                var usersData = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                var username = usersData[0];
                var date = usersData[1];
                var currentDate = DateTime.ParseExact(date, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture);

                usersDictionary[username] = currentDate;

                input = Console.ReadLine();
            }

            var sortedUsers = usersDictionary.Reverse().OrderBy(x => x.Value).Take(5).OrderByDescending(x => x.Value);


            foreach (var user in sortedUsers)
            {
                Console.WriteLine($"{user.Key}");
            }


        }
    }
}
