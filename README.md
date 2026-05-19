# ⚔️ Encuentros en la Tierra Media — Simulador de Combate RPG

Simulador de combate RPG por turnos desarrollado en C# (.NET), donde héroes y enemigos se enfrentan en encuentros tácticos. Cuenta con una jerarquía de clases completa con personajes, ítems, hechizos y un motor de encuentros que maneja toda la lógica de batalla.

---

## 🗺️ Descripción general

El sistema simula batallas grupales entre **héroes** y **enemigos**. Cada personaje tiene estadísticas base (ataque, defensa, salud) y puede equiparse con ítems que modifican esos valores. Las batallas se desarrollan ronda a ronda hasta que un bando queda completamente eliminado.

---

## 🧙 Héroes

| Clase | Ataque | Defensa | Salud | Equipamiento |
|---|---|---|---|---|
| `Knight` | 150 | 100 | 300 | Sword, Shield, Armor |
| `Wizard` | 50 | 80 | 150 | Staff, SpellsBook |
| `Archer` | 90 | 30 | 100 | Bow, Armor |
| `Dwarves` | 70 | 50 | 400 | Axe, Helmet, Shield |
| `Elves` | 50 | 20 | 300 | SpellsBook |
| `Giant` | 100 | 0 | 500 | — |

## 💀 Enemigos

| Clase | Ataque | Defensa | Salud | Puntos de Victoria |
|---|---|---|---|---|
| `Goblin` | 30 | 10 | 50 | 10 |
| `Zombie` | 20 | 5 | 80 | 15 |
| `Skeleton` | 25 | 15 | 40 | 12 |
| `Devil` | 60 | 40 | 150 | 50 |

---

## ⚙️ Cómo funciona el combate

La clase `Encounter` maneja la batalla:

1. **Los enemigos atacan primero** — cada enemigo apunta a un héroe por rotación (el enemigo `i` ataca al héroe `i % N`).
2. **Los héroes supervivientes contraatacan** — cada héroe ataca a todos los enemigos vivos.
3. **Puntos de victoria** — cuando un héroe mata a un enemigo, se lleva sus VP. Acumular **5 o más VP** activa una curación completa.
4. **La batalla termina** cuando todos los héroes o todos los enemigos están muertos.

El daño se calcula como: `ataque total del atacante − defensa total del defensor`. Si la defensa supera al ataque, no se recibe daño.

---

## 🎒 Ítems

Los ítems se dividen según su función:

- **Ofensivos** (`IOffensiveItem`): suman ataque — `Sword`, `Axe`, `Bow`, `Staff`
- **Defensivos** (`IDefensiveItem`): suman defensa — `Shield`, `Armor`, `Helmet`
- **Mixtos** — `SpellsBook` implementa ambas interfaces. Sus valores de ataque y defensa se calculan dinámicamente a partir de los objetos `Spell` que tenga cargados.

---

## 🏗️ Arquitectura

El diseño se apoya en una jerarquía limpia de herencia e interfaces:

```
ICharacter
    └── Character (abstracta)
            ├── Heroes (abstracta)
            │       ├── Knight
            │       ├── Wizard
            │       ├── Archer
            │       ├── Dwarves
            │       ├── Elves
            │       └── Giant
            └── Enemies (abstracta)
                    ├── Goblin
                    ├── Zombie
                    ├── Skeleton
                    └── Devil

IItem
    ├── IOffensiveItem  →  Sword, Axe, Bow, Staff, SpellsBook
    └── IDefensiveItem  →  Shield, Armor, Helmet, SpellsBook
```

`GetTotalAttack()` y `GetTotalDefense()` viven en `Character` e iteran sobre la lista de equipamiento — sin necesidad de sobreescribirlos en cada subclase. `SpellsBook` es el caso más interesante: recalcula sus propios valores de ataque y defensa a partir de sus hechizos cada vez que se los consulta.

---

## 🚀 Ejecutar el proyecto


`Program.cs` arma un encuentro de ejemplo: un **Gigante** y un **Mago de fuego** (con un hechizo de Bola de Fuego cargado) contra un **Goblin** y un **Zombie**. La salida registra cada derrota a medida que ocurre.

---


## 🛠️ Tecnologías

- **C# / .NET**
- POO: clases abstractas, interfaces, herencia, polimorfismo

---

## 👥 Autores

- Santiago Abella
- Rodrigo García
- Rodrigo Quincke
- Gerónimo Sosa
