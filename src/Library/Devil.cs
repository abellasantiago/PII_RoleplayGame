using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    // Representa un diablo: enemigo con alto ataque y defensa.
    // Es el enemigo más valioso, otorga 50 puntos de victoria.
    // Ataque: 60 | Defensa: 40 | Salud: 150 | VP: 50 
    public class Devil : Enemies
    {
        // Crea un nuevo diablo. 
        public Devil(string name)
            :base(name, 60, 40, 150, 50)
        {
        }
    }
}