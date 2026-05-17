using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    // Clase base abstracta para todos los enemigos del juego.
    // Extiende Character e implement IEnemies, agregando el valor de puntos del victoria que otorga al ser derrotados.

    public abstract class Enemies : Character, IEnemies
    {
        // Puntos de victoria que obtiene el héroe que derrota a este enemigo.
        public int VictoryPoints { get; private set; }

        protected Enemies(string name, int attackValue, int defenseValue, int initialHealth, int victoryPoints)
            : base(name, attackValue, defenseValue, initialHealth)
        {
            this.VictoryPoints = victoryPoints;
        }
    }
}