using System;

namespace Ucu.Poo.RolePlayGame
{
    // Representa un bastón mágico: ítem ofensivo usado por los magos.
    public class Staff : IOffensiveItem
    {
        public string Name { get; }
        public int AttackValue { get; } // Valor de ataque que aporta el bastón.
    

    public Staff(string name, int attackValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
        }
    }
}