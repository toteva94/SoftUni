namespace _03.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Dog
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int NumberOfLegs { get; set; }

        public string ProduceSound()
        {
            return "I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.";
        }

        public string Introduction()
        {
            return $"Dog: {Name}, Age: {Age}, Number Of Legs: {NumberOfLegs}";
        }
    }

    public class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int IntelligenceQuotient { get; set; }

        public string ProduseSound()
        {
            return "I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.";
        }

        public string Introduction()
        {
            return $"Cat: {Name}, Age: {Age}, IQ: {IntelligenceQuotient}";
        }
    }

    public class Snake
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int CrueltyCoefficient { get; set; }

        public string ProduseSound()
        {
            return "I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.";
        }

        public string Introduction()
        {
            return $"Snake: {Name}, Age: {Age}, Cruelty: {CrueltyCoefficient}";
        }
    }
    public class Animals
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var catsData = new Dictionary<string,Cat>();
            var dogsData = new Dictionary<string, Dog>();
            var snakesData = new Dictionary<string,Snake>();

            while (input != "I'm your Huckleberry")
            {
                var animalData = input
               .Split()
               .ToArray();


                if (animalData[0] != "talk")
                {
                    if (animalData[0] == "Dog")
                    {
                        var currentDog = new Dog
                        {
                            Name = animalData[1],
                            Age = int.Parse(animalData[2]),
                            NumberOfLegs = int.Parse(animalData[3])
                        };

                        dogsData.Add(currentDog.Name,currentDog);
                    }
                    else if (animalData[0] == "Cat")
                    {
                        var currentCat = new Cat
                        {
                            Name = animalData[1],
                            Age = int.Parse(animalData[2]),
                            IntelligenceQuotient = int.Parse(animalData[3])
                        };

                        catsData.Add(currentCat.Name,currentCat);
                    }
                    else if (animalData[0] == "Snake")
                    {
                        var currentSnake = new Snake
                        {
                            Name = animalData[1],
                            Age = int.Parse(animalData[2]),
                            CrueltyCoefficient = int.Parse(animalData[3])
                        };

                        snakesData.Add(currentSnake.Name,currentSnake);
                    }
                }
                else 
                {
                    var animalName = animalData[1];

                    foreach (var dog in dogsData.Keys)
                    {
                        if (dog == animalName)
                            Console.WriteLine(dogsData[dog].ProduceSound());
                    }

                    foreach (var cat in catsData.Keys)
                    {
                        if (cat == animalName)
                            Console.WriteLine(catsData[cat].ProduseSound());
                    }

                    foreach (var snake in snakesData.Keys)
                    {
                        if (snake == animalName)
                            Console.WriteLine(snakesData[snake].ProduseSound());
                    }
                }


                input = Console.ReadLine();
            }

            foreach (var dog in dogsData.Values)
            {
                Console.WriteLine(dog.Introduction());
            }

            foreach (var cat in catsData.Values)
            {
                Console.WriteLine(cat.Introduction());
            }

            foreach (var snake in snakesData.Values)
            {
                Console.WriteLine(snake.Introduction());
            }
        }

    }
}

