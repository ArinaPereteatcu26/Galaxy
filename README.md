# 🚀 Galaxy Assault

A cinematic 3D space shooter built in **Unity**, where the player pilots a spaceship through a dangerous part of the galaxy, fights waves of enemy ships, 
receives backup from General Nick, defeats the Big Boss, and finally reaches the Mother Ship.

---

## 🎮 Game Overview

In *Galaxy Assault*, the player controls a spaceship navigating through hostile territory. 
Enemy ships attack in increasingly difficult waves. At a critical moment, General Nick arrives to support the player.

The mission ends with an epic battle against the Big Boss ship. After defeating it, the player successfully reaches the Mother Ship.

---

## 🛠 Features & Systems Implemented

### 🌍 Environment & Visual Design
- Unity **Terrain Tools** used to create terrain
- Trees and environmental elements placed manually
- Custom lighting and rendering adjustments to simulate a galaxy atmosphere

### 🎬 Cinematics & Timeline
- **Master Timeline** used to animate the player ship
- Control Tracks used to trigger and manage enemy waves
- Cinematic event: General Nick arrival sequence

### 🎮 Player Controls
Implemented using Unity’s **Input Action Map**:

- `W` `A` `S` `D` → Move spaceship
- `Left Mouse Click` → Fire lasers

### 🔫 Combat System
- **Particle System** used to create player laser weapons
- Collision detection for:
  - Laser hitting enemy ships
  - Enemy ships colliding with the player
- Trigger-based enemy destruction logic
  
### 🔊 Audio System
- Background music for immersive gameplay
- Sound effects for:
  - Laser shooting
  - Explosions
  - Combat interactions
    
### 🧮 Score System
- UI Scoreboard implemented
- Points awarded for destroying enemy ships
- Real-time score updates during gameplay

### 💡 Additional Mechanics
- Enemy wave spawning
- Boss fight logic
- Trigger-based progression events
- Boundary clamping for player movement

---

## 🎯 Game Objective

1. Survive enemy waves  
2. Receive help from General Nick  
3. Defeat the Big Boss  
4. Reach the Mother Ship  

---

## 🖥 Controls

| Action        | Key |
|--------------|-----|
| Move         | WASD |
| Fire Laser   | Left Mouse Click |

---

## 🧑‍💻 Built With

- Unity
- C#
- Unity Input System
- Unity Timeline
- Unity Terrain Tools
- Unity Particle System

---

## 🚀 Possible Future Improvements

- Add health system and UI
- Implement power-ups
- Add difficulty scaling
- Improve boss AI behavior

---

## 👩‍🚀 Author

Developed by Pereteatcu Arina
