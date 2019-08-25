namespace GaemStuffsExempleYey.Actor.Attributes
{
    public class Wisdom : Attribute
    {
        public Wisdom() : base("Wisdom", 10, AttributeCategory.Mental)
        {
        }

        public Wisdom(int value) : base("Wisdom", value, AttributeCategory.Mental)
        {
        }
    }
}
