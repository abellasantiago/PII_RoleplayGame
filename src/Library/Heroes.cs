namespace Ucu.Poo.RolePlayGame
{
    public abstract class Heroes : Character
    {
        public int AccumulatedVictoryPoints { get; private set; }

        protected Heroes(string name, int health, int attack, int defense, int speed)
            : base(name, health, attack, defense, speed)
        {
            AccumulatedVictoryPoints = 0;
        }

        public void AddVictoryPoints(IEnemies enemies)
        {
            AccumulatedVictoryPoints += enemies.VictoryPoints;
        }
    }
}