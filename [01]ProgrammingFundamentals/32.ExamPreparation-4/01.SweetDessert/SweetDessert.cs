namespace _01.SweetDessert
{
    using System;

    public class SweetDessert
    {
        public static void Main()
        {
            var cash = decimal.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananasPrice = decimal.Parse(Console.ReadLine());
            var eggsPrice = decimal.Parse(Console.ReadLine());
            var berriesPrice = decimal.Parse(Console.ReadLine());

            var portionsCount = Math.Ceiling(guests / 6m);
            var singlePortionPrice = 2 * bananasPrice + 4 * eggsPrice + 0.2m * berriesPrice;
            var totalPrice = portionsCount * singlePortionPrice;

            if (cash >= totalPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                var withdrawMoney = totalPrice - cash;
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {withdrawMoney:F2}lv more.");
            }
        }
    }
}
