using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    // Representa una armadura: ítem defensivo usado por los caballeros y los arqueros.
    public class Armor: IDefensiveItem
    {
        public string Name { get; }
        public int DefenseValue { get; } // Valor de defensa que aporta la armadura.

        public Armor(string name, int defenseValue)
        {
            this.Name = name;
            this.DefenseValue = defenseValue;
        }
    }
}
