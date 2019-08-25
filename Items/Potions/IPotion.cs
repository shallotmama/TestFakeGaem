using GaemStuffsExempleYey.Actor.Character;
using System;

namespace GaemStuffsExempleYey.Items.Potions
{
    public interface IPotion : IItem
    {
        void Drink(Character character);
    }
}
