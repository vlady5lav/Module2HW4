using System;

namespace SafariPark
{
    public class SectionProvider : ISectionProvider
    {
        private readonly IAnimalsService _animalsService;
        private readonly Random _random;
        private readonly int _sectionSize;

        public SectionProvider(IAnimalsService animalsService, IConfigService configService)
        {
            _animalsService = animalsService;
            _random = new Random();
            _sectionSize = configService.Config.SectionConfig.SectionSize;
            Init();
        }

        public Animal[] AnimalSection { get; private set; }

        private void Init()
        {
            AnimalSection = new Animal[_sectionSize];

            for (var i = 0; i < _sectionSize; i++)
            {
                var randomIndex = _random.Next(0, _animalsService.AllAnimals.Length);
                var pickedAnimal = _animalsService.AllAnimals[randomIndex];
                AnimalSection[i] = pickedAnimal;
            }
        }
    }
}
