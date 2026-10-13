# HeartFall

**A 2D platformer prototype built with Unity and C#**

![HeartFall project preview](https://raw.githubusercontent.com/YArora5/YArora5/main/assets/heartfall-project.png)

HeartFall is a 2D platformer prototype focused on movement, combat, enemy behaviour, hazards, health, and room-based progression. The player navigates dangerous spaces, fights enemies, collects health items, and works toward the level goal.

> **Project status:** Student portfolio project. Please check the current build before assuming every listed system is fully polished or complete.

## Gameplay systems

- **Player:** movement, jumping, attack, health, respawn, and animation
- **Enemies:** melee and ranged enemy behaviours, detection, attacks, and animations
- **Combat and survival:** projectiles, damage, health pickups, and health UI
- **Level interaction:** traps, checkpoints, doors, and room transitions
- **Game flow:** restart/loading and UI systems
- **Presentation:** sound and animation integration

## Tech stack

- Unity
- C#
- Unity Animator
- 2D sprites, colliders, and physics
- UI and audio systems

## Code organization

The scripts are grouped by responsibility:

```text
Assets/Scripts/
├── Core/       # Camera and sound management
├── Enemy/      # Melee, ranged, and patrol behaviours
├── Health/     # Health, health bar, and collectibles
├── Player/     # Movement, attack, projectile, and respawn
├── Rooms/      # Doors and room transitions
├── Traps/      # Hazards and enemy damage
└── UI/         # Menus and user interface
```

## Running the project

The current repository contains the `Assets` folder and this README, but does not currently include the standard Unity `Packages` and `ProjectSettings` folders. As a result, it may not open as a complete Unity project when cloned.

To make the repository reproducible, the next repository improvement is to commit the full Unity project structure (while excluding generated folders such as `Library/`, `Temp/`, and build output). Until then, treat this repository as the project's asset/source snapshot rather than a ready-to-open Unity project.

## Controls

Controls should be confirmed against the current playable build before release. Update this section with the exact keyboard/mouse bindings once the build's input configuration is verified.

## What I learned

- Organizing gameplay code by responsibility
- Connecting player, enemy, health, hazard, and room systems
- Using Unity animation and physics workflows
- Iterating on a playable game prototype

## Next improvements

- Add a short gameplay video or GIF and multiple in-game screenshots
- Publish a playable build with a download link
- Add the complete Unity project configuration so others can clone and run it
- Document the exact controls and tested Unity version
- Add a small test checklist for movement, combat, checkpoints, and respawn
