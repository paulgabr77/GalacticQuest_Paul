using System;

namespace GalacticQuest.Items
{
    internal abstract class Item
    {
        public int Attack { get; set; }
        public int Health { get; set; }

        public abstract void SpecialPower();
    }
}
