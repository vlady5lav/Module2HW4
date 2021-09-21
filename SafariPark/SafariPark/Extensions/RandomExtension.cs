using System;

namespace SafariPark
{
    public static class RandomExtension
    {
        public static double NextDoubleValue(this Random random, double minValue, double maxValue)
        {
            return (random.NextDouble() * (maxValue - minValue)) + minValue;
        }

        public static double NextDoubleValue(this Random random, double maxValue)
        {
            return random.NextDouble() * maxValue;
        }

        public static bool NextBool(this Random random, int truePercentage = 50)
        {
            return random.NextDouble() < truePercentage / 100.0;
        }
    }
}
