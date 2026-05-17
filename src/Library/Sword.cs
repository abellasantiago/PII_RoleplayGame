using System;

namespace Ucu.Poo.RolePlayGame
{
    // Representa una espada: ítem ofensivo usado por los caballeros.
    public class Sword : IOffensiveItem
    {
        public string Name { get; }
        public int AttackValue { get; } // Valor de ataque que aporta la espada.
    

    public Sword(string name, int attackValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
        }
    }
}