using System;


namespace GalacticQuest.Monsters
{
    internal class Ignifax : Monster
    {
        public Ignifax()
        {
            Name = "Ignifax";
            Hp = 120;
            Attack = 25;
        }

        public override void BattleCry()
        {
            Console.WriteLine($"FEEL THE WRATH OF FLAMES! I AM {Name}!");
        }

        public override void OnDeath()
        {
            Console.WriteLine("Ignifax erupts in a burst of flames as it collapses...");
        }
    }
}
