using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    // Representa un casco: ítem defensivo usado por los enanos.
    public class Helmet: IDefensiveItem
    {
        public string Name { get; }
        public int DefenseValue { get; } // Valor de defensa que aporta el casco.

        public Helmet(string name, int defenseValue)
        {
            this.Name = name;
            this.DefenseValue = defenseValue;
        }
    }
}