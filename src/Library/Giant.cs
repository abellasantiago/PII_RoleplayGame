using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    // Representa un gigante: héroe con mucho ataque y salud, pero sin defensa.
    // Ataque base: 100 | Defensa base: 0 | Salud: 500
    public class Giant : Heroes
    {
        // Crea un nuevo gigante.
        public Giant(string name)
            :base(name, 100, 0, 500)
        {
        }
    }
}