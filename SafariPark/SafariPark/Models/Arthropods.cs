namespace SafariPark
{
    public abstract class Arthropods : Animal
    {
        public Arthropods()
        {
            GlobalType = GlobalAnimalTypes.Arthropods;
            IsVertebrate = false;
        }

        public ArthropodsTypes ArthropodType { get; set; }
        public bool MoreThanThreePairOfLegs { get; set; }
    }
}
