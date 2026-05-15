//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main(string[] args)
        {
            // Se crean primero los heroes
            Console.WriteLine("Bienvenido al juego!");
            Console.WriteLine("Creacion de heroes");

            Giant ogro = new Giant("Ogro");
            Console.WriteLine("Gigante: " + ogro.Name);

            Wizard mago = new Wizard("Mago de fuego");
            Console.WriteLine("Mago: " + mago.Name);
            Spell fireball = new Spell("Bola de fuego", 50, 0);
            mago.SpellsBook.AddSpell(fireball);

            // Se crean los enemigos
            Console.WriteLine("Creacion de enemigos");
            Goblin goblin = new Goblin("Duende malvado");
            Console.WriteLine("Goblin: " + goblin.Name);
            Zombie zombie = new Zombie("Zombie");
            Console.WriteLine("Zombie: " + zombie.Name);

            Console.WriteLine("Simulacion de un encuentro");
            // Se simula un encuentro
            Encounter encounter = new Encounter();
            // Se agrupan enemigos y heroes en listas para pasarlos al encuentro
            List<Enemies> enemies = new List<Enemies> { goblin, zombie};
            List<Heroes> heroes = new List<Heroes> { ogro, mago};

            // Se inicia
            encounter.DoEncounter(enemies, heroes);
        }
    }
}
