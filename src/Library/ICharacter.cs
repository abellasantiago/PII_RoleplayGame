using System;

namespace Ucu.Poo.RolePlayGame
{
    // Define el contrato que debe cumplir cualquier personaje del juego, heroe o enemigo.
    public interface ICharacter
    {
        string Name { get; } // Nombre del personaje.
        int Health { get; } // Puntos de salud.
        int GetTotalAttack(); // Ataque total, incluyendo sus items ofensivos equipados.
        int GetTotalDefense(); // Defensa total, incluyendo sus items defensivos equipados.
        void ReceiveAttack(ICharacter attacker); // Recibe un ataque de otro personaje. El daño efectivo es el diferencia entre el ataque del atacante y la defensa total de este personaje.
        void Cure(); // Restaura la salud del personaje a su valor inicial.

        void AddItem(IItem item); // Agrega un ítem al equipamiento del personaje.
        void RemoveItem(IItem item); // Elimina un ítem al equipamiento del personaje.
    }
}