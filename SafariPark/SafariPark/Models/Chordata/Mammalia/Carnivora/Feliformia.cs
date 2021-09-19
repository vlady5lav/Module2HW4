namespace SafariPark
{
    public abstract class Feliformia : Carnivora
    {
        public Feliformia()
        {
            CarnivoraType = CarnivoraTypes.Feliformia;
        }

        public FeliformiaTypes FeliformiaType { get; set; }
    }
}
