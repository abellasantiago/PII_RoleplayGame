# ⚔️ Middle Earth Encounters — RPG Combat Simulator

A turn-based RPG combat simulator built in C# (.NET), where heroes and enemies clash in tactical encounters. Features a full class hierarchy with characters, items, spells, and an encounter engine that drives the battle logic.

---

## 🗺️ Overview

The system simulates group battles between **heroes** and **enemies**. Each character has base stats (attack, defense, health) and can be equipped with items that modify those stats. Battles play out round by round until one side is completely wiped out.

---

## 🧙 Heroes

| Class | Attack | Defense | Health | Equipment |
|---|---|---|---|---|
| `Knight` | 150 | 100 | 300 | Sword, Shield, Armor |
| `Wizard` | 50 | 80 | 150 | Staff, SpellsBook |
| `Archer` | 90 | 30 | 100 | Bow, Armor |
| `Dwarves` | 70 | 50 | 400 | Axe, Helmet, Shield |
| `Elves` | 50 | 20 | 300 | SpellsBook |
| `Giant` | 100 | 0 | 500 | — |

## 💀 Enemies

| Class | Attack | Defense | Health | Victory Points |
|---|---|---|---|---|
| `Goblin` | 30 | 10 | 50 | 10 |
| `Zombie` | 20 | 5 | 80 | 15 |
| `Skeleton` | 25 | 15 | 40 | 12 |
| `Devil` | 60 | 40 | 150 | 50 |

---

## ⚙️ How Combat Works

The `Encounter` class drives the battle:

1. **Enemies attack first** — each enemy targets a hero by rotation (enemy `i` attacks hero `i % N`).
2. **Surviving heroes counterattack** — each hero attacks every living enemy.
3. **Victory points** — when a hero kills an enemy, they earn that enemy's VP. Reaching **5+ accumulated VP** triggers a full heal.
4. **Battle ends** when all heroes or all enemies are dead.

Damage is calculated as: `attacker's total attack − defender's total defense`. If defense exceeds attack, no damage is dealt.

---

## 🎒 Items

Items are split by function:

- **Offensive** (`IOffensiveItem`): add to attack — `Sword`, `Axe`, `Bow`, `Staff`
- **Defensive** (`IDefensiveItem`): add to defense — `Shield`, `Armor`, `Helmet`
- **Mixed** — `SpellsBook` implements both interfaces. Its attack and defense values are computed dynamically from the `Spell` objects loaded into it.

---

## 🏗️ Architecture

The design is built around a clean inheritance and interface hierarchy:

```
ICharacter
    └── Character (abstract)
            ├── Heroes (abstract)
            │       ├── Knight
            │       ├── Wizard
            │       ├── Archer
            │       ├── Dwarves
            │       ├── Elves
            │       └── Giant
            └── Enemies (abstract)
                    ├── Goblin
                    ├── Zombie
                    ├── Skeleton
                    └── Devil

IItem
    ├── IOffensiveItem  →  Sword, Axe, Bow, Staff, SpellsBook
    └── IDefensiveItem  →  Shield, Armor, Helmet, SpellsBook
```

`GetTotalAttack()` and `GetTotalDefense()` live in `Character` and iterate over the equipment list — no need to override per subclass. `SpellsBook` is the interesting edge case: it recalculates its own attack/defense values from its spells each time those methods are called.

---

## 🚀 Running the Project

```bash
dotnet run
```

`Program.cs` sets up a sample encounter: a **Giant** and a **fire Wizard** (with a Fireball spell loaded) vs. a **Goblin** and a **Zombie**. Output logs each defeat as it happens.

---

## 📐 UML Class Diagram

![UML Diagram](UML_Clases.png)

---

## 🛠️ Tech Stack

- **C# / .NET**
- OOP: abstract classes, interfaces, inheritance, polymorphism

---

## 👥 Authors

- Santiago Abella
- Rodrigo García  
- Rodrigo Quincke
- Gerónimo Sosa
