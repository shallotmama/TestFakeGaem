namespace GaemStuffsExempleYey.Actor.Attributes
{
    public class Dexterity : Attribute
    {
        public Dexterity() : base("Dexterity", 10, AttributeCategory.Physical)
        {
        }

        public Dexterity(int value) : base("Dexterity", value, AttributeCategory.Physical)
        {
        }
    }
}
