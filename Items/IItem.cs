using System;

namespace GaemStuffsExempleYey.Items
{
    public interface IItem
    {
        string Name { get; }
        Guid Id { get; }
    }
}
