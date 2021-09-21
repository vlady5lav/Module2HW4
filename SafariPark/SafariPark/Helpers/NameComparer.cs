using System.Collections;

namespace SafariPark
{
    public class NameComparer : IComparer, INameComparer
    {
        public int Compare(object x, object y)
        {
            var animalX = x as Animal;
            var animalY = y as Animal;

            var animalXnameChars = animalX.Name.ToString().ToCharArray();
            var animalYnameChars = animalY.Name.ToString().ToCharArray();

            var length = animalXnameChars.Length <= animalYnameChars.Length ? animalXnameChars.Length : animalYnameChars.Length;

            for (var i = 0; i < length; i++)
            {
                if (animalXnameChars[i] > animalYnameChars[i])
                {
                    return 1;
                }
                else if (animalXnameChars[i] < animalYnameChars[i])
                {
                    return -1;
                }
            }

            return 0;
        }
    }
}
