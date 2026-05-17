using System;

namespace Ucu.Poo.RolePlayGame
{
    // Representa un arco: ítem ofensivo usado por los arqueros.
    public class Bow : IOffensiveItem
    {
        public string Name { get; }
        public int AttackValue { get; } // Valor de ataque que aporta el arco.
    

    public Bow(string name, int attackValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
        }
    }
}