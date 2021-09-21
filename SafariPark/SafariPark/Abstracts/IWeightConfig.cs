namespace SafariPark
{
    public interface IWeightConfig
    {
        WeightUnits CurrentWeight { get; set; }
        WeightData[] WeightData { get; set; }
    }
}