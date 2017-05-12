namespace _02.OptimizedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BankAccount
    {
        public string Name { get; set; }

        public string Bank { get; set; }

        public decimal Balance { get; set; }
    }

    public class OptimizedBankingSystem
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var bankAccountsData = new List<BankAccount>();

            while (input != "end")
            {
                var currentAccount = ReadBankAccountsData(input);

                var allreadyExist = bankAccountsData.Any(x => x.Bank == currentAccount.Bank && x.Name == currentAccount.Name);

                if (allreadyExist)
                    bankAccountsData.SingleOrDefault(x => x.Bank == currentAccount.Bank && x.Name == currentAccount.Name).Balance += currentAccount.Balance;
                else
                    bankAccountsData.Add(currentAccount);
                

                input = Console.ReadLine();
            }

            foreach (var bank in bankAccountsData.OrderByDescending(x => x.Balance).ThenBy(x => x.Bank.Length))
            {
                Console.WriteLine($"{bank.Name} -> {bank.Balance} ({bank.Bank})");
            }
        }

        public static BankAccount ReadBankAccountsData(string input)
        {
            var bankAccountsElements = input
                .Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            return new BankAccount
            {
                Bank = bankAccountsElements[0],
                Name = bankAccountsElements[1],
                Balance = decimal.Parse(bankAccountsElements[2]),

            };
        }
    }
}
