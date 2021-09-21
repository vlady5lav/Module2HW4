using System.Collections;

namespace SafariPark
{
    public class HeightComparer : IComparer, IHeightComparer
    {
        public int Compare(object x, object y)
        {
            var animalX = x as Animal;
            var animalY = y as Animal;

            if (animalX.Height > animalY.Height)
            {
                return 1;
            }
            else if (animalX.Height < animalY.Height)
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
