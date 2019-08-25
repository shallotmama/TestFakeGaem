using GaemStuffsExempleYey.Actor.Character;

namespace GaemStuffsExempleYey.Items
{
    public interface IEquippable : IItem
    {
        InventorySlot Slot { get; }
        void Equip(Character character);
        void Unequip(Character character);
    }
}
