namespace Ucu.Poo.RolePlayGame
{
    public abstract class Heroes : Character
    {
        public int AccumulatedVictoryPoints { get; private set; }

        protected Heroes(string name, int attackValue, int defenseValue, int initialHealth)
            : base(name, attackValue, defenseValue, initialHealth)
        {
            AccumulatedVictoryPoints = 0;
        }

        public void AddVictoryPoints(IEnemies enemies)
        {
            AccumulatedVictoryPoints += enemies.VictoryPoints;
        }
    }
}