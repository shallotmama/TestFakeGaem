using System;

namespace GaemStuffsExempleYey.Actor.Attributes
{
    public abstract class Attribute
    {
        public string Name { get; }
        public byte Value
        {
            get { return Value; }
            set
            {
                if (value < 1 || value > 20)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Must be between 1 and 255");
                }

                Value = value;
            }
        }

        public AttributeCategory Category { get; }

        public Attribute(string name, byte value, AttributeCategory category)
        {
            Name = name;
            Value = value;
            Category = category;
        }

        public static Attribute operator +(Attribute a, Attribute b)
        {
            if (a.Name.Equals(b.Name))
            {
                a.Value += b.Value;
            }
            return a;
        }

        public static Attribute operator -(Attribute a, Attribute b)
        {
            if (a.Name.Equals(b.Name))
            {
                a.Value -= b.Value;
            }
            return a;
        }
    }
}
