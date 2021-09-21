namespace SafariPark
{
    public interface IConfig
    {
        HeightConfig HeightConfig { get; set; }
        SectionConfig SectionConfig { get; set; }
        WeightConfig WeightConfig { get; set; }
    }
}