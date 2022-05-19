using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPoo.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int Hp=75, int Mp=40) 
            : base(Name, Level, HeroType, Hp, Mp)
        {
        }
        public override string Attack()
        {
            return $"{this.Name} lançou magia";
        }

        public string Attack(int bonus)
        {
            if (bonus > 6)
            {
                return $"{this.Name} lançou magia com dano critico de +{bonus} de bonus de ataque";
            }
            else
            {
                return $"{this.Name} lançou magia com +{bonus} de bonus de ataque";
            }
            
        }
    }
}
