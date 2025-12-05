using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticQuest.Models
{
    internal class Kraken : Monsters
    {
        public override int HP { get; set; } = 300;
        public override int Attack { get; set; } = 50;
        public override void BattleCry()
        {
            Console.WriteLine("Kraken roars fiercely, shaking the very seas!");
        }

        public override void OnDeath()
        {
            Console.WriteLine("The mighty Kraken has been defeated!");
        }

    }
}
