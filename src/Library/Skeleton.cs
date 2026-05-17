using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    // Representa un esqueleto: enemigo con ataque y defensa moderados, poca salud.
    // Ataque: 25 | Defensa: 15 | Salud: 40 | VP: 12
    public class Skeleton : Enemies
    {
        // Crea un nuevo esqueleto.
        public Skeleton(string name)
            :base(name, 25, 15, 40, 12)
        {
        }
    }
}