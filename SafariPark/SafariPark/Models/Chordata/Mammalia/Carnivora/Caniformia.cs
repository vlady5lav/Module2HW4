namespace SafariPark
{
    public abstract class Caniformia : Carnivora
    {
        public Caniformia()
        {
            CarnivoraType = CarnivoraTypes.Caniformia;
        }

        public CaniformiaTypes CaniformiaType { get; set; }
    }
}
