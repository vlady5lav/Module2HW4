namespace SafariPark
{
    public interface IHeightConfig
    {
        HeightUnits CurrentHeight { get; set; }
        HeightData[] HeightData { get; set; }
    }
}