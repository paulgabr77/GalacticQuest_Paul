using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticQuest.Models
{
    internal class Vioraptoru : Monsters
    {
        public override void BattleCry()
        {
            Console.WriteLine("Va omor pe toti");
        }

        public override void OnDeath()
        {
            Console.WriteLine("Vioraptoru a fost invins!");
        }
        public override string Name { get ; set ; }
    }
}
