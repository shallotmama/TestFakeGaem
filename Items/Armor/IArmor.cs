namespace GaemStuffsExempleYey.Items.Armor
{
    public interface IArmor : IEquippable
    {
        short Protection { get; }
        ArmorType Type { get; }
    }
}
