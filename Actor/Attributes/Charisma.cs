namespace GaemStuffsExempleYey.Actor.Attributes
{
    public class Charisma : Attribute
    {
        public Charisma() : base("Charisma", 10, AttributeCategory.Mental)
        {
        }

        public Charisma(int value) : base("Charisma", value, AttributeCategory.Mental)
        {
        }
    }
}
