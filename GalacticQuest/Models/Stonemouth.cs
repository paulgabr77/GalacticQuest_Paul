namespace GalacticQuest.Monsters
{
    internal class Stonemouth : Monster
    {
        public Stonemouth()
        {
            Name = "Stonemouth";
            Hp = 200;
            Attack = 10;
        }

        public override void BattleCry()
        {
            Console.WriteLine($"THE EARTH TREMBLES AT MY PRESENCE! I AM {Name}!");
        }
        public override void OnDeath()
        {
            Console.WriteLine("Stonemouth collapses into rubble, shaking the ground...");
        }
    }
}
