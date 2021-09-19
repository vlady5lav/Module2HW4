namespace SafariPark
{
    public class AnimalsService : IAnimalsService
    {
        private readonly IAnimalsProvider _animalsProvider;
        private readonly IConfigService _configService;
        private readonly HeightData[] _heightData;
        private readonly WeightData[] _weightData;

        public AnimalsService(IAnimalsProvider animalsProvider, IConfigService configService)
        {
            _animalsProvider = animalsProvider;

            _configService = configService;
            _heightData = _configService.Config.HeightConfig.HeightData;
            _weightData = _configService.Config.WeightConfig.WeightData;

            Init();
        }

        public Animal[] AllAnimals { get; private set; }

        private void ConvertHeight(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                var heightData = GetHeightData(animal.HeightUnit);
                animal.Height *= heightData.DefaultToCurrentRate;
                animal.HeightUnit = _configService.Config.HeightConfig.CurrentHeight;
            }
        }

        private HeightData GetHeightData(HeightUnits heightUnit)
        {
            foreach (var heightData in _heightData)
            {
                if (heightData.HeightUnit == heightUnit)
                {
                    return heightData;
                }
            }

            return null;
        }

        private void ConvertWeight(Animal[] animals)
        {
            foreach (var animal in animals)
            {
                var weightData = GetWeightData(animal.WeightUnit);
                animal.Weight *= weightData.DefaultToCurrentRate;
                animal.WeightUnit = _configService.Config.WeightConfig.CurrentWeight;
            }
        }

        private WeightData GetWeightData(WeightUnits weightUnit)
        {
            foreach (var weightData in _weightData)
            {
                if (weightData.WeightUnit == weightUnit)
                {
                    return weightData;
                }
            }

            return null;
        }

        private void Init()
        {
            AllAnimals = new Animal[_animalsProvider.AllAnimals.Length];
            _animalsProvider.AllAnimals.CopyTo(AllAnimals, 0);
            ConvertHeight(AllAnimals);
            ConvertWeight(AllAnimals);
        }
    }
}
