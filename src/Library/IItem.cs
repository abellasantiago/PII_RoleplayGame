using System;

// Define las propiedades mínimas que debe cumplir cualquier ítem del juego.
// Todo ítem tiene al menos un nombre.
public interface IItem
{
    string Name { get; }

}