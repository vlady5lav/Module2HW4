namespace SafariPark
{
    public abstract class Chordata : Animal
    {
        public Chordata()
        {
            GlobalType = GlobalAnimalTypes.Chordata;
            IsVertebrate = true;
        }

        public ChordataTypes ChordataType { get; set; }
        public virtual bool IsWarmBlooded { get; set; }
        public virtual bool IsTetrapoda { get; set; }
    }
}
