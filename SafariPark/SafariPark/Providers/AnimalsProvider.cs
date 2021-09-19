using System;

namespace SafariPark
{
    public class AnimalsProvider : IAnimalsProvider
    {
        private readonly Random _random;

        public AnimalsProvider()
        {
            _random = new Random();
            Init();
        }

        public Animal[] AllAnimals { get; private set; }

        private void Init()
        {
            AllAnimals = new Animal[]
            {
                new Alpaca(),
                new Antelope(),
                new Ape(),
                new ArcticFox(),
                new Badger(),
                new Beaver(),
                new BlackBear(),
                new Camel(),
                new Capybara(),
                new Cattle(),
                new Coati(),
                new Coyote(),
                new Deer(),
                new Dog(),
                new Elephant(),
                new EuropeanBrownHare(),
                new Fox(),
                new Giraffe(),
                new Goat(),
                new Hare(),
                new Hippopotamus(),
                new Jackal(),
                new Lemur(),
                new Lion(),
                new Llama(),
                new Monkey(),
                new MountainHare(),
                new Mouse(),
                new Otter(),
                new Peccarie(),
                new Pig(),
                new Pika(),
                new PolarBear(),
                new Porcupine(),
                new Rabbit(),
                new Racoon(),
                new Rat(),
                new RedPanda(),
                new Seal(),
                new SeaLion(),
                new Sheep(),
                new Skunk(),
                new Squirrel(),
                new StinkBadger(),
                new SunBear(),
                new Tiger(),
                new Walrus(),
                new Weasel(),
                new Wolf(),
            };

            foreach (var animal in AllAnimals)
            {
                animal.Name = animal.GetType().Name;
                animal.Height = _random.Next(100, 1000);
                animal.Weight = _random.NextDoubleValue(100);
                animal.HeightUnit = (HeightUnits)_random.Next(2);
                animal.WeightUnit = (WeightUnits)_random.Next(3);
            }
        }
    }
}
