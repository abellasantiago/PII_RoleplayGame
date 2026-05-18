using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    // Representa un combate entre un grupo de héroes y un grupo de enemigos.
    public class Encounter
    {
        // Ejecuta el encuentro: los enemigos atacan primero en rotación, luego los héroes
        // sobrevivientes atacan a todos los enemigos. Termina cuando un bando queda sin
        // miembros vivos. Si un héroe acumula 5 o más VP, se cura.
        public void DoEncounter(List<Enemies> enemies, List<Heroes> heroes)
        {
            List<Heroes> aliveHeroes = new List<Heroes>(heroes);
            List<Enemies> aliveEnemies = new List<Enemies>(enemies);

            while (aliveHeroes.Count > 0 && aliveEnemies.Count > 0)
            {
                // Cada enemigo ataca a un héroe en rotación: el enemigo i ataca al héroe i % N.
                for (int i = 0; i < aliveEnemies.Count; i++)
                {
                    Heroes target = aliveHeroes[i % aliveHeroes.Count];
                    target.ReceiveAttack(aliveEnemies[i]);
                }

                // Eliminar héroes caídos antes de que contraataquen.
                aliveHeroes = aliveHeroes.FindAll(h => h.Health > 0);

                if (aliveHeroes.Count == 0)
                {
                    Console.WriteLine("Todos los heroes han sido derrotados.");
                    break;
                }

                // Cada héroe sobreviviente ataca a todos los enemigos aún vivos.
                foreach (Heroes hero in aliveHeroes)
                {
                    foreach (Enemies enemy in aliveEnemies)
                    {
                        if (enemy.Health > 0)
                        {
                            int healthBefore = enemy.Health;
                            enemy.ReceiveAttack(hero);

                            // Si el enemigo pasó de vivo a muerto en este ataque, el héroe se lleva sus VP.
                            if (healthBefore > 0 && enemy.Health <= 0)
                            {
                                Console.WriteLine($"{enemy.Name} ha sido derrotado por {hero.Name}.");
                                hero.AddVictoryPoints(enemy);

                                // Si el héroe alcanza 5 o más VP acumulados, se cura.
                                if (hero.AccumulatedVictoryPoints >= 5)
                                    hero.Cure();
                            }
                        }
                    }
                }

                // Eliminar enemigos caídos antes de iniciar la siguiente ronda.
                aliveEnemies = aliveEnemies.FindAll(e => e.Health > 0);
            }

            if (aliveEnemies.Count == 0)
                Console.WriteLine("Todos los enemigos han sido derrotados.");
        }
    }
}