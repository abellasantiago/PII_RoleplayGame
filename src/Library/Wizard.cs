using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Ucu.Poo.RolePlayGame
{
    // Representa a un mago: héroe magico con alta defensa.
    // Ataque base: 50 | Defensa base: 80 | Salud: 150
    // Equipo: Staff (+30 ataque), SpellsBook.
    public class Wizard : Heroes
    {
        public Staff Staff { get; private set; } 
        public SpellsBook SpellsBook { get; private set; }  

        // Crea un nuevo mago con su equipamiento.
        public Wizard(string name)
            : base(name,50, 80,150)  
        {
            this.Staff = new Staff("Staff", 30);
            this.SpellsBook = new SpellsBook("Wizards Book");
            this.Equipment.Add(this.Staff);
            this.Equipment.Add(this.SpellsBook);
        }
    }
}