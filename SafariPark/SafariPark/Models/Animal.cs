namespace SafariPark
{
    public abstract class Animal
    {
        public string Name { get; set; }
        public virtual double Height { get; set; }
        public virtual HeightUnits HeightUnit { get; set; } = HeightUnits.M;
        public virtual double Weight { get; set; }
        public virtual WeightUnits WeightUnit { get; set; } = WeightUnits.KG;
        public virtual GlobalAnimalTypes GlobalType { get; init; }
        public virtual AnimalColors Color { get; set; } = AnimalColors.Black;
        public virtual CoveringTypes Covering { get; set; } = CoveringTypes.Fur;
        public virtual bool IsVertebrate { get; set; }
        public virtual int Quantity { get; set; }
    }
}
