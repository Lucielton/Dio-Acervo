using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetPoo.src.Entities
{
    public abstract class Hero
    {
        public string Name;
        public int Level;
        public string HeroType;
        public int Hp;
        public int Mp;

        public Hero(string Name, int Level, string HeroType, int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }

        public override string ToString()
        {
            return $"{this.Name} {this.HeroType} {this.Level}";
        }

        public virtual string Attack()
        {
            return $"{this.Name} atacou com sua espada";
        }
    }
}
