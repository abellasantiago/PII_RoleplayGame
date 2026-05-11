using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    public class Character
    {
        public string Name {get; }
        public int AttackValue {get; } 
        private int DefenseValue {get; }
        private int InitialHealth {get; }
        public int Health {get; private set; }
        public List<IItem> Equipment { get; private set; }


        public Character(string name, int attackvalue, int defensevalue, int initialhealth, int health)
        {
            this.Name = name;
            this.AttackValue = attackvalue;
            this.DefenseValue = defensevalue;
            this.InitialHealth = initialhealth;
            this.Health = this.InitialHealth;
        }

        public void ReceiveAttack(ICharacter attacker)
        {
            int actualDamage = attacker.GetTotalAttack() - this.GetTotalDefense();
            if (actualDamage > 0)
            {
                this.Health -= actualDamage;
            }
        }

        public void Cure()
        {
            this.Health = this.InitialHealth;
        }

        public int GetTotalAttack()
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

        public int GetTotalDefense()
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
    }
}