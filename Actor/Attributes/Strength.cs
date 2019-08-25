namespace GaemStuffsExempleYey.Actor.Attributes
{
    public class Strength : Attribute
    {
        public Strength() : base("Strength", 10, AttributeCategory.Physical)
        {
        }

        public Strength(int value) : base("Strength", value, AttributeCategory.Physical)
        {
        }
    }
}
