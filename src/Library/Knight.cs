using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    // Representa un caballero: héroe equlibrado con buen ataque y defensa.
    // Ataque base: 150 | Defensa base: 100 | Salud: 300
    // Equipo: Sword (+50 ataque), Shield (+20 defensa), Armor (+50 defensa)
    public class Knight : Heroes
    {
        public Sword Sword { get; private set; } 
        public Shield Shield { get; private set; } 
        public Armor Armor { get; private set; } 

        // Crea un nuevo caballero con su equipamiento.
        public Knight(string name)
            : base(name, 150, 100, 300)
        {
            this.Sword = new Sword("Sword", 50);
            this.Shield = new Shield("Shield", 20);
            this.Armor = new Armor("Armor", 50);
            this.Equipment.Add(this.Sword);
            this.Equipment.Add(this.Shield);
            this.Equipment.Add(this.Armor);
        }
    }
}