namespace SafariPark
{
    public abstract class Lagomorpha : Mammalia
    {
        public Lagomorpha()
        {
            MammaliaType = MammaliaTypes.Lagomorpha;
        }

        public LagomorphaTypes LagomorphaType { get; set; }
    }
}
