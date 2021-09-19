namespace SafariPark
{
    public abstract class Mammalia : Chordata
    {
        public Mammalia()
        {
            ChordataType = ChordataTypes.Mammalia;
            IsWarmBlooded = true;
            IsTetrapoda = true;
        }

        public MammaliaTypes MammaliaType { get; set; }
    }
}
