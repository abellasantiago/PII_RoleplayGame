using System;

namespace Ucu.Poo.RolePlayGame
{
    // Representa un hechizo que puede ser registrado en un Libro de Hechizos. 
    public class Spell
    {
        public string Name { get; }
        public int AttackValue { get; } // Valor de ataque que aporta el hechizo.
        public int DefenseValue { get; } // Valor de defensa que aporta el hechizo.
    

    public Spell(string name, int attackValue, int defenseValue)
        {
            this.Name = name;
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;

        }
    }
}