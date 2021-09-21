namespace SafariPark
{
    public abstract class Amphibians : Chordata
    {
        public Amphibians()
        {
            ChordataType = ChordataTypes.Amphibians;
            IsWarmBlooded = false;
            IsTetrapoda = true;
            Covering = CoveringTypes.SoftMoistSkin;
        }
    }
}
