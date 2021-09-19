namespace SafariPark
{
    public abstract class Pantheras : Feliformia
    {
        public Pantheras()
        {
            FeliformiaType = FeliformiaTypes.Pantheras;
        }

        public PantherasTypes PantheraType { get; set; }
    }
}
