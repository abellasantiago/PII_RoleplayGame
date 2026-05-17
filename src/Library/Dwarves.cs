using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Ucu.Poo.RolePlayGame
{
    // Representa a un enano: héroe con mucha salud y defensa.
    // Ataque base: 70 | Defensa base: 50 | Salud: 400
    // Equipo: Axe (+30 ataque), Helmet (+15 defensa), Shield (+20 defensa)
    public class Dwarves : Heroes
    {
        public Axe Axe { get; private set; } 
        public Shield Shield { get; private set; } 
        public Helmet Helmet { get; private set; } 

        // Crea un nuevo enano con su equipamiento
        public Dwarves(string name)
            : base(name, 70, 50, 400)
        {
            this.Axe = new Axe("Axe", 30);
            this.Helmet = new Helmet("Helmet", 15);
            this.Shield = new Shield("Shield", 20);
            this.Equipment.Add(this.Axe);
            this.Equipment.Add(this.Helmet);
            this.Equipment.Add(this.Shield);
        }
    }
}