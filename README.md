# 🚀 Galaxy Assault

A cinematic 3D space shooter built in **Unity**, where the player pilots a spaceship through a dangerous part of the galaxy, fights waves of enemy ships, 
receives backup from General Nick, defeats the Big Boss, and finally reaches the Mother Ship.

Available at: https://play.unity.com/en/games/e3f9f613-606c-4ada-9237-56b3e1003083/galaxy-assault

---

## Game Overview

In *Galaxy Assault*, the player controls a spaceship navigating through hostile territory. 
Enemy ships attack in increasingly difficult waves. At a critical moment, General Nick arrives to support the player.
<img width="828" height="476" alt="Screenshot 2026-02-26 154118" src="https://github.com/user-attachments/assets/0545e852-17cd-4039-92c5-eaa0956845fc" />

The mission ends with an epic battle against the Big Boss ship. After defeating it, the player successfully reaches the Mother Ship.

---

## Features & Systems Implemented
- Unity **Terrain Tools** used to create terrain
- Trees and environmental elements placed manually
- Custom lighting and rendering adjustments to simulate a galaxy atmosphere

### Cinematics & Timeline
- **Master Timeline** used to animate the player ship
- Control Tracks used to trigger and manage enemy waves
- Cinematic event: General Nick arrival sequence

<img width="1628" height="830" alt="Screenshot 2026-02-26 154153" src="https://github.com/user-attachments/assets/475f8bfa-647e-4e0a-b8ba-581115491dbb" />

### Player Controls
Implemented using Unity’s **Input Action Map**:

- `W` `A` `S` `D` → Move spaceship
- `Left Mouse Click` → Fire lasers

### Combat System
- **Particle System** used to create player laser weapons
- Collision detection for:
  - Laser hitting enemy ships
  - Enemy ships colliding with the player
- Trigger-based enemy destruction logic

<img width="1547" height="844" alt="Screenshot 2026-02-26 154132" src="https://github.com/user-attachments/assets/e9dbeecf-592f-4306-ae27-d9bb60817367" />

### Audio System
- Background music for immersive gameplay
- Sound effects for:
  - Laser shooting
  - Explosions
  - Combat interactions
    
### Score System
- UI Scoreboard implemented
- Points awarded for destroying enemy ships
- Real-time score updates during gameplay

### Additional Mechanics
- Enemy wave spawning
- Boss fight logic
- Trigger-based progression events
- Boundary clamping for player movement

---

## Game Objective

1. Survive enemy waves  
2. Receive help from General Nick  
3. Defeat the Big Boss  
4. Reach the Mother Ship  

---

## Controls

| Action        | Key |
|--------------|-----|
| Move         | WASD |
| Fire Laser   | Left Mouse Click |

---

## Built With

- Unity
- C#
- Unity Input System
- Unity Timeline
- Unity Terrain Tools
- Unity Particle System

---

## Possible Future Improvements

- Add health system and UI
- Implement power-ups
- Add difficulty scaling
- Improve boss AI behavior

---

## Author

Developed by Pereteatcu Arina
