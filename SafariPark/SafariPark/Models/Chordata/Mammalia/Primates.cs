namespace SafariPark
{
    public abstract class Primates : Mammalia
    {
        public Primates()
        {
            MammaliaType = MammaliaTypes.Primates;
        }

        public PrimatesTypes PrimateType { get; set; }
    }
}
