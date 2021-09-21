namespace SafariPark
{
    public class WeightConfig : IWeightConfig
    {
        public WeightData[] WeightData { get; set; }
        public WeightUnits CurrentWeight { get; set; }
    }
}
