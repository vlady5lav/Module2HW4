namespace SafariPark
{
    public abstract class Birds : Chordata
    {
        public Birds()
        {
            ChordataType = ChordataTypes.Birds;
            IsWarmBlooded = true;
            IsTetrapoda = true;
            Covering = CoveringTypes.Feathers;
        }
    }
}
