namespace Ucu.Poo.RolePlayGame
{
    // Clase base abstacta para todos los héros del juego.
    // Extiende Character agregando el concepto de puntos de puntos de victoria acumulados
    // Los heroes ganan puntos de victoria al derrotar enemigos.
    public abstract class Heroes : Character
    {
        // Total de puntos de victoria acumulados por este héroe.
        public int AccumulatedVictoryPoints { get; private set; }

        protected Heroes(string name, int attackValue, int defenseValue, int initialHealth)
            : base(name, attackValue, defenseValue, initialHealth)
        {
            this.AccumulatedVictoryPoints = 0;
        }

        // Suma los puntos de victoria del enemigo derrotado al acumulado del héroe.
        public void AddVictoryPoints(IEnemies enemy)
        {
            this.AccumulatedVictoryPoints += enemy.VictoryPoints;
        }
    }
}