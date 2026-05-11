namespace Ucu.Poo.RolePlayGame
{
    public abstract class Enemies : Character, IEnemies
    {
        public int VictoryPoints { get; }

        protected Enemies(string name, int health, int attack, int defense, int speed, int victoryPoints)
            : base(name, health, attack, defense, speed)
        {
            VictoryPoints = victoryPoints;
        }
    }
}