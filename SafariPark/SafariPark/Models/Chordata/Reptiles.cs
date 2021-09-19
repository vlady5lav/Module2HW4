namespace SafariPark
{
    public abstract class Reptiles : Chordata
    {
        public Reptiles()
        {
            ChordataType = ChordataTypes.Reptiles;
            IsWarmBlooded = false;
            IsTetrapoda = true;
            Covering = CoveringTypes.DryScales;
        }
    }
}
