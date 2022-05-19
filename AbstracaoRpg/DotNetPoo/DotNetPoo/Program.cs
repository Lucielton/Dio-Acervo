using DotNetPoo.src.Entities;
using System;

namespace DotNetPoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paladin hero = new Paladin("Arus", 15, "Paladin");
            Wizard jennefer = new Wizard("Jennefer", 37, "Black Mage");

            
            Console.WriteLine(hero.Attack());
            Console.WriteLine(jennefer.Attack());
            Console.WriteLine(jennefer.Attack(10));
            Console.WriteLine(jennefer.Hp);
        }
    }
}
