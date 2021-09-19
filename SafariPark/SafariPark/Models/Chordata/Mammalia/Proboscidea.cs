namespace SafariPark
{
    public abstract class Proboscidea : Mammalia
    {
        public Proboscidea()
        {
            MammaliaType = MammaliaTypes.Proboscidea;
        }

        public ProboscideaTypes ProboscideaType { get; set; }
    }
}
