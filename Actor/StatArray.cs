using GaemStuffsExempleYey.Actor.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace GaemStuffsExempleYey.Actor
{
    public class StatArray
{
        public Strength Strength { get; set; }
        public Dexterity Dexterity { get; set; }
        public Constitution Constitution { get; set; }
        public Intelligence Intelligence { get; set; }
        public Wisdom Wisdom { get; set; }
        public Charisma Charisma { get; set; }

        public StatArray()
        {
            Strength = new Strength();
            Dexterity = new Dexterity();
            Constitution = new Constitution();
            Intelligence = new Intelligence();
            Wisdom = new Wisdom();
            Charisma = new Charisma();
        }

        public StatArray(short str, short dex, short con, short intel, short wis, short cha)
        {
            Strength = new Strength(str);
            Dexterity = new Dexterity(dex);
            Constitution = new Constitution(con);
            Intelligence = new Intelligence(intel);
            Wisdom = new Wisdom(wis);
            Charisma = new Charisma(cha);
        }

        public void ResetToDefault()
        {
            Strength.Value = 10;
            Dexterity.Value = 10;
            Constitution.Value = 10;
            Intelligence.Value = 10;
            Wisdom.Value = 10;
            Charisma.Value = 10;
        }

        public void Roll()
        {
            Random r = new Random();

            Strength.Value = (short)r.Next(1, 256);
            Dexterity.Value = (short)r.Next(1, 256);
            Constitution.Value = (short)r.Next(1, 256);
            Intelligence.Value = (short)r.Next(1, 256);
            Wisdom.Value = (short)r.Next(1, 256);
            Charisma.Value = (short)r.Next(1, 256);
        }
    }
}
