namespace SafariPark
{
    public interface ISectionService
    {
        Animal[] AnimalSection { get; }
        Animal[] FilteredAnimalSection { get; }
        int SectionTotalSpecies { get; }
        Animal[] SortedAnimalSection { get; }
        Animal[] TotalSpeciesArray { get; }
        void GetFilteredAnimalSection(double height);
        void GetFilteredAnimalSection(MammaliaTypes type);
        void GetFilteredAnimalSection(string name);
        void GetSortedAnimalSection(string sort);
    }
}