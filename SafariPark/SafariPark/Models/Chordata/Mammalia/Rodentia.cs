namespace SafariPark
{
    public abstract class Rodentia : Mammalia
    {
        public Rodentia()
        {
            MammaliaType = MammaliaTypes.Rodentia;
        }

        public RodentiaTypes RodentiaType { get; set; }
    }
}
