using System;

namespace GalacticQuest.Items
{
    internal class ShadowAmulet : Item
    {
        public ShadowAmulet()
        {
            Attack = 10;
            Health = 30;
        }

        public override void SpecialPower()
        {
            Console.WriteLine("The Shadow Amulet cloaks you in darkness, reducing enemy damage!");
        }
    }
}
