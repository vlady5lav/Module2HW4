namespace SafariPark
{
    public static class ArrayHelper
    {
        public static void ReverseAnimalsArray(Animal[] animals)
        {
            var start = 0;
            var end = animals.Length - 1;

            Animal temp;

            while (start < end)
            {
                temp = animals[start];
                animals[start] = animals[end];
                animals[end] = temp;
                start++;
                end--;
            }
        }

        public static object[] CleanCapacity(Animal[] animals)
        {
            var count = 0;

            foreach (var item in animals)
            {
                if (item != null)
                {
                    count++;
                }
            }

            var result = new Animal[count];

            foreach (var item in animals)
            {
                if (item != null)
                {
                    result[--count] = item;
                }
            }

            ReverseAnimalsArray(result);

            return result;
        }
    }
}
