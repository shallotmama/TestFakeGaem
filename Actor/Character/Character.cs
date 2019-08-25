using System;
using System.Collections.Generic;
using GaemStuffsExempleYey.Actor;
using GaemStuffsExempleYey.Items;

namespace GaemStuffsExempleYey.Actor.Character
{
    public abstract class Character : IActor
    {
        public string Name { get; }
        public StatArray Stats { get; }
        public CharacterClass Class { get; set; }
        public ICollection<IEquippable> EquippedItems { get; } = new List<IEquippable>(11);
        public int CurrentHealth {
            get { return CurrentHealth; }
            set { CurrentHealth = Math.Min(Math.Max(0, value), MaxHealth); }
        }
        public int MaxHealth { get; set; }
        public byte ArmorClass { get; set; }

        public Character(string name, CharacterClass cClass)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Class = cClass;
            Stats = new StatArray();
            Stats.Roll();
        }

        public Character(string name, CharacterClass cClass, StatArray stats)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (stats == null)
            {
                Stats = new StatArray();
            }
            else
            {
                Stats = stats;
            }

            Name = name;
            Class = cClass;
        }

        public Character(string name, int str, int dex, int con, int intel, int wis, int cha)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Stats = new StatArray(str, dex, con, intel, wis, cha);
        }

        public void EquipItem(IEquippable item)
        {
            foreach(IEquippable e in EquippedItems)
            {
                if(e.Slot == item.Slot)
                {
                    e.Unequip(this);
                }
            }

            item.Equip(this);
        }

        public void ReapplyAttributeBonuses()
        {
            foreach(Attribute att in Stats)
            {

            }
        }
    }
}
