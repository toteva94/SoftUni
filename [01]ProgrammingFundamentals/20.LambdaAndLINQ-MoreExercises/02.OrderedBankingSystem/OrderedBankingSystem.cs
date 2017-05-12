namespace _02.OrderedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class OrderedBankingSystem
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var bankAccountsData = new Dictionary<string, Dictionary<string, decimal>>();

            while (input != "end")
            {
                var elements = input.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var bank = elements[0];
                var account = elements[1];
                var balance = decimal.Parse(elements[2]);

                if (!bankAccountsData.ContainsKey(bank))
                    bankAccountsData[bank] = new Dictionary<string, decimal>();
                if (!bankAccountsData[bank].ContainsKey(account))
                    bankAccountsData[bank][account] = 0;
                bankAccountsData[bank][account] += balance;

                input = Console.ReadLine();
            }

            foreach (var bank in bankAccountsData
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value)))
            {
                foreach (var account in bank.Value.OrderByDescending(account => account.Value))
                {
                    Console.WriteLine($"{account.Key} -> {account.Value} ({bank.Key})");
                }
            }

        }
    }
}
