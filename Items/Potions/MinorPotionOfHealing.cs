using GaemStuffsExempleYey.Actor.Character;
using System;

namespace GaemStuffsExempleYey.Items.Potions
{
    public class MinorPotionOfHealing : IPotion
    {
        public string Name => "Minor Potion of Healing";
        public Guid Id => new Guid("38e49de2-3708-488b-bfd4-70a6f3275cd0");
        public MinorPotionOfHealing()
        {
        }

        public void Drink(Character character)
        {
            character.CurrentHealth += 10;
        }
    }
}
