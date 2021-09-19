namespace SafariPark
{
    public class Config : IConfig
    {
        public HeightConfig HeightConfig { get; set; }
        public WeightConfig WeightConfig { get; set; }
        public SectionConfig SectionConfig { get; set; }
    }
}
