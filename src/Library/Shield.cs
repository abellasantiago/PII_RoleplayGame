using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    // Representa un escudo: ítem defensivo usado por los caballeros y por los enanos.
    public class Shield : IDefensiveItem
    {
        public string Name { get; }
        public int DefenseValue { get; } // Valor de defensa que aporta el escudo.

        public Shield(string name, int defenseValue)
        {
            this.Name = name;
            this.DefenseValue = defenseValue;
        }
    }
}