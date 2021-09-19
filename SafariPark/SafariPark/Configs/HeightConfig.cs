namespace SafariPark
{
    public class HeightConfig : IHeightConfig
    {
        public HeightData[] HeightData { get; set; }
        public HeightUnits CurrentHeight { get; set; }
    }
}
