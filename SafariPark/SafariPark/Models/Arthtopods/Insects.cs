namespace SafariPark
{
    public abstract class Insects : Arthropods
    {
        public Insects()
        {
            ArthropodType = ArthropodsTypes.Insects;
            MoreThanThreePairOfLegs = false;
        }
    }
}
