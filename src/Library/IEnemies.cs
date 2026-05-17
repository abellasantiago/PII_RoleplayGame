using System;

// Define las propiedades mínimas que tiene cualquier enemigo.
// Los enemigos tienen puntos de victoria que los otorgan al héros que los derrota.
public interface IEnemies
{
    int VictoryPoints { get; }
}