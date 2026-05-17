using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    // Clase abstracta para todos los personajes del juego (héroes y enemigos).
    // Implementa la lógica de combate, equipamiento y curación.
    // Aplica de forma efectiva la reutilización de código: toda la información de héroes y enemigos compartida está en este clase.
    // Evita duplicación de código.

    public class Character : ICharacter
    {
        public string Name {get; } // Nombre del personaje.
        public int AttackValue {get; } // Valor de ataque base del personaje.
        protected int DefenseValue {get; } // Valor de defensa base del personaje.
        protected int InitialHealth {get; } // Salud con la que el personaje empieza (y a la que vuelven al curarse).
        public int Health {get; private set; } // Salud actual del personaje.
        public List<IItem> Equipment { get; private set; } // Lista de ítems que el personaje tiene equipados.


        // Inicializa un nuevo personaje con sus atributos base.
        protected Character(string name, int attackValue, int defenseValue, int initialHealth)
        {
            this.Name = name;
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
            this.InitialHealth = initialHealth;
            this.Health = initialHealth;
            this.Equipment = new List<IItem>();
        }

        // Recibe un ataque de otro personaje.
        // El daño real es la diferencia entre el ataque del atacante y la defensa del personaje que recibe.
        // Si la defensa supera al ataque, no se recibe daño.
        public void ReceiveAttack(ICharacter attacker)
        {
            int actualDamage = attacker.GetTotalAttack() - this.GetTotalDefense();
            if (actualDamage > 0)
            {
                this.Health -= actualDamage;
            }
        }

        // Restaura la salud del personaje a su valor inicial.
        public void Cure()
        {
            this.Health = this.InitialHealth;
        }

        // Calcula el ataque total: ataque base más el aporte de todos los ítems ofensivos equipados.
        public virtual int GetTotalAttack()
        {
            int total = this.AttackValue;
            foreach (IItem item in this.Equipment)
            {
                if (item is IOffensiveItem)
                {
                    IOffensiveItem offensiveItem = (IOffensiveItem)item;
                    total += offensiveItem.AttackValue;
                }
            }
            return total;
        }

        // Calcula la defensa total: defensa base más el aporte de todos los ítems defensivos equipados.
        public virtual int GetTotalDefense()
        {
            int total = this.DefenseValue;
            foreach (IItem item in this.Equipment)
            {
                if (item is IDefensiveItem)
                {
                    IDefensiveItem defensiveItem = (IDefensiveItem)item;
                    total += defensiveItem.DefenseValue;
                }
            }
            return total;
        }

        // Agrega un ítem al equipamiento del personaje.
        public void AddItem(IItem item)
        {
            this.Equipment.Add(item);
        }

        // Elimina un ítem del equipamiento del personaje.
        public void RemoveItem(IItem item)
        {
            this.Equipment.Remove(item);
        }
    }
}