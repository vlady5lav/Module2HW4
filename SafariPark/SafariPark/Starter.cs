using System;

namespace SafariPark
{
    public class Starter
    {
        private readonly ISectionService _sectionService;

        public Starter(ISectionService sectionService)
        {
            _sectionService = sectionService;
        }

        public void Run()
        {
            Console.WriteLine($"{Environment.NewLine}All animals in section:{Environment.NewLine}");

            foreach (var animal in _sectionService.AnimalSection)
            {
                Console.WriteLine($"{animal.Name}");
            }

            Console.WriteLine($"{Environment.NewLine}=================================================================");

            Console.WriteLine($"{Environment.NewLine}Filtered animals by type \"Artiodactyla\":{Environment.NewLine}");

            foreach (var animal in _sectionService.FilteredAnimalSection)
            {
                Console.WriteLine($"{animal.Name}");
            }

            Console.WriteLine($"{Environment.NewLine}=================================================================");

            Console.WriteLine($"{Environment.NewLine}Sorted animals by Name:{Environment.NewLine}");

            foreach (var animal in _sectionService.SortedAnimalSection)
            {
                Console.WriteLine($"{animal.Name}");
            }

            Console.WriteLine($"{Environment.NewLine}=================================================================");

            Console.WriteLine($"{Environment.NewLine}Unique species (Total: {_sectionService.SectionTotalSpecies} species):{Environment.NewLine}");

            foreach (var animal in _sectionService.TotalSpeciesArray)
            {
                Console.WriteLine($"{animal.Name}");
            }

            Console.WriteLine(string.Empty);
            Console.ReadKey();
        }
    }
}
