using System;

namespace Ucu.Poo.RolePlayGame
{
    // Representa un hacha: ítem ofensivo usado por los enanos.
    public class Axe : IOffensiveItem
    {
        public string Name { get; }
        public int AttackValue { get; } // Valor de ataque que aporta el hacha.
    

    public Axe(string name, int attackValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
        }
    }
}