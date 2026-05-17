using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    // Representa un goblin: enemigo débil con poca salud y poca defensa.
    // Fácil de derrotar, otorga pocos puntos de victoria.
    // Ataque: 30 | Defensa: 10 | Salud: 50 | VP: 10
    public class Goblin : Enemies
    {
        // Crea un nuevo goblin.
        public Goblin(string name)
            :base(name, 30, 10, 50, 10)
        {
        }
    }
}