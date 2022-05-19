using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPoo.src.Entities
{
    public class Paladin : Hero
    {
        public Paladin(string Name, int Level, string HeroType, int Hp=100, int Mp=25) 
            : base(Name, Level, HeroType, Hp, Mp)
        {
        }
    }
}
