using System;
using System.Collections.Generic;
using static System.String;

namespace _07.FixEmails
{
    public class FixEmails
    {
        public static void Main()
        {
           var emailsData = new Dictionary<string,string>();

            while (true)
            {
                var currentName = Console.ReadLine();

                if (currentName == "stop")
                {
                    break;
                }

                var currentEmail = Console.ReadLine();
                var currentEmailParts = currentEmail.Split('@');
                var currentEmailDomainName = currentEmailParts[1].Split('.');
                var currentEmailDomainExtention = currentEmailDomainName[1].ToLower();

                if (currentEmailDomainExtention == "uk" || currentEmailDomainExtention == "us")
                {
                    break;
                }

                if (!emailsData.ContainsKey(currentName))
                {
                    emailsData[currentName] = string.Empty;
                }

                emailsData[currentName] = currentEmail;
            }

            foreach (var nameAndEmail in emailsData)
            {
                Console.WriteLine($"{nameAndEmail.Key} -> {nameAndEmail.Value}");
            }
        }
    }
}