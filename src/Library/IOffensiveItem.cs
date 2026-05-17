using System;

// Define el contrato de un ítem ofensivo.
// Los ítem ofensivo hereda de IItem y además aportan un valor de ataque.
public interface IOffensiveItem : IItem
{
    int AttackValue { get; }

}