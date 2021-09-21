namespace SafariPark
{
    public abstract class Carnivora : Mammalia
    {
        public Carnivora()
        {
            MammaliaType = MammaliaTypes.Carnivora;
        }

        public CarnivoraTypes CarnivoraType { get; set; }
    }
}
