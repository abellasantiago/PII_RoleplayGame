using System;
using System.Collections.Generic;

namespace Ucu.Poo.RolePlayGame
{
    // Libro de hechizos que actúa como ítem ofensivo y defensivo.
    // Sus valores de ataque y defensa son calculados en base a los hechizos que contiene.
    public class SpellsBook : IOffensiveItem, IDefensiveItem
    {
        public string Name { get; }
        public int AttackValue { get; set; } // Valor de ataque total: suma los valores de ataque de todos los hechizos registrados.
        public int DefenseValue { get; set; } //  Valor de defensa total: suma los valores de defensa de todos los hechizos registrados.
        public List<Spell> Spells { get; private set; } // Lista de hechizos registrados en este libro.
    

        public SpellsBook(string name)
        {
            this.Name = name;
            this.Spells = new List<Spell>();

        }

        // Agrega un hechizo al libro.
        public void AddSpell(Spell spell)
        {
            this.Spells.Add(spell);
        }

        // Elimina un hechizo del libro.
        public void RemoveSpell(Spell spell)
        {
            this.Spells.Remove(spell);
        }

        // Calcula el ataque total sumando los valores de ataque de todos los hechizos.
        public int GetTotalAttack()
        {
            int total = 0;
            foreach (Spell spell in this.Spells)
            {
                total += spell.AttackValue;
            }
            return this.AttackValue = total;
        }
        
        // Calcula la defensa total sumando los valores de defensa de todos los hechizos.
        public int GetTotalDefense()
        {
            int total = 0;
            foreach (Spell spell in this.Spells)
            {
                total += spell.DefenseValue;
            }
            return this.DefenseValue = total;
        }
    }
}