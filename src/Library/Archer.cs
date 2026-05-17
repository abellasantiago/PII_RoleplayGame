using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    // Representa un arquero: héroe con ataque a distancia.
    // Ataque base: 90 | Defensa base: 30 | Salud: 100
    // Equipo: Bow (+40 ataque), Armor (+50 defensa)
    public class Archer : Heroes
    {
        public Bow Bow { get; private set; } 
        public Armor Armor { get; private set; }

        // Crea un nuevo arquero con su equipamiento.
        public Archer(string name)
            : base(name, 90, 30, 100)
        {
            this.Bow = new Bow("Bow", 40);
            this.Armor = new Armor("Armor", 50);
            this.Equipment.Add(this.Bow);
            this.Equipment.Add(this.Armor);
        }

    }
}