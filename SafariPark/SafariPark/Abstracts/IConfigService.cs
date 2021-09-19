namespace SafariPark
{
    public interface IConfigService
    {
        IConfig Config { get; }
        IHeightConfig HeightConfig { get; }
        ISectionConfig SectionConfig { get; }
        IWeightConfig WeightConfig { get; }
    }
}