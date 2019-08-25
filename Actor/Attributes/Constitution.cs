namespace GaemStuffsExempleYey.Actor.Attributes
{
    public class Constitution : Attribute
    {
        public Constitution() : base("Constitution", 10, AttributeCategory.Physical)
        {
        }

        public Constitution(int value) : base("Constitution", value, AttributeCategory.Physical)
        {
        }
    }
}
