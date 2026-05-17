using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    // Representa un elfo: héroe mágico.
    // Ataque base: 50 | Defensa base: 20 | Salud: 300
    // Equipo: SpellBook
    public class Elves : Heroes
    {
        public SpellsBook SpellsBook { get; private set; }

        // Crea un nuevo elfo con su equipamiento.
        public Elves(string name)
            : base(name, 50, 20, 300)
        {
            this.SpellsBook = new SpellsBook("Elves Book");
            this.Equipment.Add(this.SpellsBook);
        }
    }
}