namespace SafariPark
{
    public static class AnimalsSearchExtension
    {
        public static Animal[] Search(this Animal[] animals, string name)
        {
            var indexes = new int[animals.Length];
            var cycle = 0;
            var lastindex = 0;

            foreach (var animal in animals)
            {
                if (animal.Name.Contains(name))
                {
                    indexes[lastindex] = cycle;
                    lastindex++;
                }

                cycle++;
            }

            return GetFiltered(animals, indexes, lastindex);
        }

        public static Animal[] Search(this Animal[] animals, double weight)
        {
            var indexes = new int[animals.Length];
            var cycle = 0;
            var lastindex = 0;

            foreach (var animal in animals)
            {
                if (animal.Weight <= weight + 100 && animal.Weight >= weight - 100)
                {
                    indexes[lastindex] = cycle;
                    lastindex++;
                }

                cycle++;
            }

            return GetFiltered(animals, indexes, lastindex);
        }

        public static Animal[] Search(this Animal[] animals, MammaliaTypes type)
        {
            var indexes = new int[animals.Length];
            var cycle = 0;
            var lastindex = 0;

            foreach (Mammalia animal in animals)
            {
                if (animal.MammaliaType == type)
                {
                    indexes[lastindex] = cycle;
                    lastindex++;
                }

                cycle++;
            }

            return GetFiltered(animals, indexes, lastindex);
        }

        public static Animal[] GetFiltered(Animal[] animals, int[] indexes, int lastindex)
        {
            var filteredAnimals = new Animal[lastindex];

            for (var i = 0; i < lastindex; i++)
            {
                filteredAnimals[i] = animals[indexes[i]];
            }

            filteredAnimals.SortByName();
            return filteredAnimals;
        }
    }
}
