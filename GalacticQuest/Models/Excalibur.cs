using System;

namespace GalacticQuest.Items
{
    internal class Excalibur : Item
    {
        public Excalibur()
        {
            Attack = 50;
            Health = 0;
        }

        public override void SpecialPower()
        {
            Console.WriteLine("Excalibur unleashes a holy strike, doubling attack for one turn!");
        }
    }
}
