namespace SafariPark
{
    public static class AnimalsTotalsExtension
    {
        public static double GetTotalWeight(this Animal[] animals)
        {
            double totalWeight = 0.0D;

            foreach (var animal in animals)
            {
                totalWeight += animal.Weight;
            }

            return totalWeight;
        }

        public static int GetTotalAnimals(this Animal[] animals)
        {
            var totalAnimals = 0;

            foreach (var animal in animals)
            {
                totalAnimals += 1;
            }

            return totalAnimals;
        }

        /*
         * can't use it because I shouldn't know anout this :D
         *
        public static int GetTotalSpecies(this Animal[] animals)
        {
            return animals.Distinct().ToArray().Length;
        }
        */

        public static Animal[] GetTotalSpeciesArray(this Animal[] animals)
        {
            var duples = new int[animals.Length];
            var duplesCount = 0;

            for (var i = 0; i < animals.Length; i++)
            {
                for (var j = i + 1; j < animals.Length; j++)
                {
                    if (animals[i] == animals[j])
                    {
                        duples[j] = 1;
                        duplesCount++;
                        break;
                    }
                }
            }

            var unique = new Animal[animals.Length - duplesCount];
            var index = 0;

            for (var i = 0; i < animals.Length; i++)
            {
                if (duples[i] == 0)
                {
                    unique[index] = animals[i];
                    index++;
                }
            }

            unique.SortByName();
            return unique;
        }
    }
}
