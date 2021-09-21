namespace SafariPark
{
    public abstract class Artiodactyla : Mammalia
    {
        public Artiodactyla()
        {
            MammaliaType = MammaliaTypes.Artiodactyla;
        }

        public ArtiodactylaTypes ArtiodactylaType { get; set; }
    }
}
