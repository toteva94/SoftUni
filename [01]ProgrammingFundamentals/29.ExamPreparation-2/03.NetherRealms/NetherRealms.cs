namespace _03.NetherRealms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Demon
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }
    }

    public class NetherRealms
    {
        public static void Main()
        {
            var demonsNames = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var demonsBook = new SortedDictionary<string, Demon>();

            foreach (var demonName in demonsNames)
            {
                var healthSymbols = demonName
                    .Where(d => !char.IsDigit(d) && d != '+' && d != '-' && d != '*' && d != '.' && d != '.' && d != '/');

                var health = 0;

                foreach (var healthSymbol in healthSymbols)
                {
                    health += healthSymbol;
                }

                var regex = new Regex(@"[-+]?\d+\.?\d*");

                var damageMatches = regex.Matches(demonName);

                var damage = 0.0;

                foreach (Match damageMatch in damageMatches)
                {
                    var currentNumber = double.Parse(damageMatch.Value);
                    damage += currentNumber;
                }

                var modifiers = demonName.Where(d => d == '*' || d == '/').ToArray();

                foreach (var modifier in modifiers)
                {
                    if (modifier == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                demonsBook.Add(demonName, new Demon
                {
                    Name = demonName,
                    Health = health,
                    Damage = damage
                });
            }

            foreach (var demonData in demonsBook)
            {
                var demonsName = demonData.Key;
                var demonsInfo = demonData.Value;

                Console.WriteLine($"{demonsName} - {demonsInfo.Health} health, {demonsInfo.Damage:f2} damage");
            }
        }
    }
}
