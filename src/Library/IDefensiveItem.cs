using System;

// Define el contrato de un ítem defensivo.
// Los ítems defensivos heredan de IItem y además aportan un valor de defensa.
public interface IDefensiveItem : IItem
{
    int DefenseValue { get; }
}