using System;
using System.Collections;

namespace SafariPark
{
    public static class AnimalsSortExtension
    {
        private static readonly HeightComparer _heightComparer;
        private static readonly WeightComparer _weightComparer;
        private static readonly NameComparer _nameComparer;

        static AnimalsSortExtension()
        {
            _heightComparer = new HeightComparer();
            _weightComparer = new WeightComparer();
            _nameComparer = new NameComparer();
        }

        public static void SortByName(this Animal[] animals)
        {
            Array.Sort(animals, _nameComparer);
        }

        public static void SortByHeight(this Animal[] animals)
        {
            Array.Sort(animals, _heightComparer);
        }

        public static void SortByWeight(this Animal[] animals)
        {
            Array.Sort(animals, _weightComparer);
        }

        public static void SortByChoose(this Animal[] animals, IComparer comparer)
        {
            Array.Sort(animals, comparer);
        }
    }
}
