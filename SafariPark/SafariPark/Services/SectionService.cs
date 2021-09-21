using System;

namespace SafariPark
{
    public class SectionService : ISectionService
    {
        private readonly ISectionProvider _sectionProvider;

        public SectionService(ISectionProvider sectionProvider)
        {
            _sectionProvider = sectionProvider;
            Init();
        }

        public Animal[] AnimalSection { get; private set; }
        public Animal[] FilteredAnimalSection { get; private set; }
        public Animal[] SortedAnimalSection { get; private set; }
        public Animal[] TotalSpeciesArray { get; private set; }
        public int SectionTotalSpecies { get; private set; }

        public void GetFilteredAnimalSection(string name)
        {
            FilteredAnimalSection = new Animal[AnimalSection.Search(name).Length];
            FilteredAnimalSection = AnimalSection.Search(name);
        }

        public void GetFilteredAnimalSection(double height)
        {
            FilteredAnimalSection = new Animal[AnimalSection.Search(height).Length];
            FilteredAnimalSection = AnimalSection.Search(height);
        }

        public void GetFilteredAnimalSection(MammaliaTypes type)
        {
            FilteredAnimalSection = new Animal[AnimalSection.Search(type).Length];
            FilteredAnimalSection = AnimalSection.Search(type);
        }

        public void GetSortedAnimalSection(string sort)
        {
            SortedAnimalSection = new Animal[AnimalSection.Length];
            AnimalSection.CopyTo(SortedAnimalSection, 0);

            switch (sort)
            {
                case "Name":
                    SortedAnimalSection.SortByName();
                    return;
                case "Weight":
                    SortedAnimalSection.SortByWeight();
                    return;
                case "Height":
                    SortedAnimalSection.SortByHeight();
                    return;
                default:
                    throw new Exception("Error!");
            }
        }

        private void Init()
        {
            AnimalSection = new Animal[_sectionProvider.AnimalSection.Length];
            _sectionProvider.AnimalSection.CopyTo(AnimalSection, 0);
            GetFilteredAnimalSection(MammaliaTypes.Artiodactyla);
            GetSortedAnimalSection("Name");
            TotalSpeciesArray = AnimalSection.GetTotalSpeciesArray();
            SectionTotalSpecies = TotalSpeciesArray.Length;
        }
    }
}
