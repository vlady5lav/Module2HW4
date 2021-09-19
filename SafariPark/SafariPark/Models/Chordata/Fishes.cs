namespace SafariPark
{
    public abstract class Fishes : Chordata
    {
        public Fishes()
        {
            ChordataType = ChordataTypes.Fishes;
            IsWarmBlooded = false;
            IsTetrapoda = false;
            Covering = CoveringTypes.WetSlimyScales;
        }
    }
}
