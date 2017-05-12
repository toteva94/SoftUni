namespace _04.Websites
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Website
    {
        public string Host { get; set; }

        public string Domain { get; set; }

        public List<string> Queries { get; set; }

    }
    public class Websites
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var websiteData = new List<Website>();

            while (input != "end")
            {
                var currentWebsiteData = input
                 .Split(new char[] { ' ', '|', ',' }, StringSplitOptions.RemoveEmptyEntries);

                if (currentWebsiteData.Length > 2)
                {
                    var currentWebsite = new Website
                    {
                        Host = currentWebsiteData[0],
                        Domain = currentWebsiteData[1],
                        Queries = currentWebsiteData.Skip(2).ToList(),
                    };

                    websiteData.Add(currentWebsite);
                }

                else
                {
                    var currentWebsite = new Website
                    {
                        Host = currentWebsiteData[0],
                        Domain = currentWebsiteData[1],
                        Queries = new List<string>()
                    };

                    websiteData.Add(currentWebsite);
                }


                input = Console.ReadLine();
            }

            foreach (var website in websiteData)
            {
                if (website.Queries.LongCount() > 0)
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}/query?=[{string.Join("]&[",website.Queries)}]");
                }
                else
                {
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                }
            }
        }
    }
}

