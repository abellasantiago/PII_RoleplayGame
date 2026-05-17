using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    // // Representa un zombie: enemigo lento con poco ataque y salud moderada.
    public class Zombie : Enemies
    {
        // Crea un nuevo zombie.
        public Zombie(string name)
            :base(name, 20, 5, 80, 15)
        {
        }
    }
}