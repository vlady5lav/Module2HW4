using System.Collections;

namespace SafariPark
{
    public class WeightComparer : IComparer, IWeightComparer
    {
        public int Compare(object x, object y)
        {
            var animalX = x as Animal;
            var animalY = y as Animal;

            if (animalX.Weight > animalY.Weight)
            {
                return 1;
            }
            else if (animalX.Weight < animalY.Weight)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
