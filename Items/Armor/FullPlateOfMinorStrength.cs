using GaemStuffsExempleYey.Actor.Character;
using System;
using System.Collections.Generic;
using System.Text;

namespace GaemStuffsExempleYey.Items.Armor
{
    public class FullPlateOfMinorStrength : IArmor
    {
        public string Name => "Full Plate of Minor Strength";
        public Guid Id => new Guid("38e49de2-3708-488b-bfd4-70a6f3275cd0");
        public short Protection => 10;
        public InventorySlot Slot => InventorySlot.Body;
        public ArmorType Type => ArmorType.Heavy;

        public FullPlateOfMinorStrength() { }

        public void Equip(Character character)
        {
            character.ArmorClass += Protection;
            character.Stats.Strength.Value += 1;
            character.EquippedItems.Add(this);
        }
        public void UnEquip(Character character)
        {
            character.ArmorClass -= Protection;
            character.Stats.Strength.Value -= 1;
            character.EquippedItems.Remove(this);
        }
    }
}
