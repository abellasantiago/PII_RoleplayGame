using System.Collections.Generic;
using NUnit.Framework;

namespace Ucu.Poo.RolePlayGame.Tests
{
    public class EncounterTest
    {
        private Encounter encounter;

        [SetUp]
        public void Setup()
        {
            encounter = new Encounter();
        }

        [Test]
        public void DoEncounter_AllEnemiesDie_HeroesAlive()
        {
            Giant giant = new Giant("Giant");
            Goblin goblin = new Goblin("Goblin");

            List<Enemies> enemies = new List<Enemies> { goblin };
            List<Heroes> heroes = new List<Heroes> { giant };

            encounter.DoEncounter(enemies, heroes);

            Assert.That(goblin.Health, Is.LessThanOrEqualTo(0));
            Assert.That(giant.Health, Is.GreaterThan(0));
        }

        [Test]
        public void DoEncounter_AllHeroesDie_EnemiesAlive()
        {
            Elves elves = new Elves("Elves");
            List<Enemies> enemies = new List<Enemies>();
            for (int i = 0; i < 30; i++)
            {
                enemies.Add(new Goblin("Goblin" + i));
            }
            List<Heroes> heroes = new List<Heroes> { elves };

            encounter.DoEncounter(enemies, heroes);

            Assert.That(elves.Health, Is.LessThanOrEqualTo(0));
        }

        [Test]
        public void DoEncounter_HeroKillsEnemy_AccumulatesVictoryPoints()
        {
            Giant giant = new Giant("Giant");
            Goblin goblin = new Goblin("Goblin");

            List<Enemies> enemies = new List<Enemies> { goblin };
            List<Heroes> heroes = new List<Heroes> { giant };

            encounter.DoEncounter(enemies, heroes);

            Assert.That(giant.AccumulatedVictoryPoints, Is.GreaterThan(0));
        }

        [Test]
        public void DoEncounter_HeroReaches5VP_GetsHealed()
        {
            Giant giant = new Giant("Giant");
            Zombie zombie = new Zombie("Zombie");

            List<Enemies> enemies = new List<Enemies> { zombie };
            List<Heroes> heroes = new List<Heroes> { giant };

            encounter.DoEncounter(enemies, heroes);

            Assert.That(giant.AccumulatedVictoryPoints, Is.GreaterThanOrEqualTo(5));
            Assert.That(giant.Health, Is.EqualTo(500));
        }

        [Test]
        public void DoEncounter_EnemyAttackRotation_CorrectTargeting()
        {
            Giant hero0 = new Giant("Hero0");
            Giant hero1 = new Giant("Hero1");

            Goblin enemy0 = new Goblin("Enemy0");
            Goblin enemy1 = new Goblin("Enemy1");
            Goblin enemy2 = new Goblin("Enemy2");

            List<Enemies> enemies = new List<Enemies> { enemy0, enemy1, enemy2 };
            List<Heroes> heroes = new List<Heroes> { hero0, hero1 };

            encounter.DoEncounter(enemies, heroes);

            Assert.That(hero0.AccumulatedVictoryPoints, Is.GreaterThan(hero1.AccumulatedVictoryPoints));
        }
    }
}