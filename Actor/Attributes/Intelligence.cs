namespace GaemStuffsExempleYey.Actor.Attributes
{
    public class Intelligence : Attribute
    {
        public Intelligence() : base("Intelligence", 10, AttributeCategory.Mental)
        {
        }

        public Intelligence(int value) : base("Intelligence", value, AttributeCategory.Mental)
        {
        }
    }
}
