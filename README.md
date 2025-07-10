# Flarpy-Blorb 🐦

A fun Flappy Bird clone built with Unity! Guide your bird through pipes and try to achieve the highest score possible.

## 📷 Screenshots

![Gameplay Screenshot 1](Screenshots/Screenshot%202025-07-11%20000658.png)
_Main gameplay - Navigate through the pipes!_

![Gameplay Screenshot 2](Screenshots/Screenshot%202025-07-11%20000837.png)
_In-game action showing the bird and pipe obstacles_

![Gameplay Screenshot 3](Screenshots/Screenshot%202025-07-11%20000908.png)
_Game interface and scoring system_

## 🎮 How to Play

- **Click** or **Tap** to make the bird flap and rise
- Navigate through the gaps between pipes
- Avoid hitting pipes or the ground
- Try to achieve the highest score!

## 🛠️ Built With

- **Unity** 6000.1.10f1
- **C#** for game logic
- **Unity Input System** for cross-platform input handling
- **2D Physics** for realistic bird movement

## 🎯 Game Features

- ✅ Smooth bird physics and flap mechanics
- ✅ Infinite pipe spawning system
- ✅ Score tracking and collision detection
- ✅ Cloud background elements for visual appeal
- ✅ Cross-platform input support (mouse and touch)
- ✅ Game over and restart functionality

## 📁 Project Structure

```
Assets/
├── Scripts/           # Game logic and mechanics
│   ├── BirdScript.cs          # Bird movement and input
│   ├── PipeSpawnScript.cs     # Pipe generation system
│   ├── PipeMoveScript.cs      # Pipe movement logic
│   ├── LogicManagerScript.cs  # Game state management
│   ├── TriggerScript.cs       # Score detection
│   └── CloudScript.cs         # Background elements
├── Images/            # Sprites and visual assets
│   ├── bird.png
│   ├── unitytut-pipe.png
│   └── unitytut-cloud.png
├── Audio/             # Sound effects
│   └── retro-coin.mp3
└── Scenes/            # Unity scenes
    └── MainScene.unity
```

## 🎵 Audio

The game features retro-style sound effects including:

- Sound for scoring

## 🚀 Getting Started

### Prerequisites

- Unity 6000.1.10f1 or later
- Basic understanding of Unity development (for modifications)

### Installation

1. Clone this repository
2. Open the project in Unity
3. Open the `StartScene` in the Scenes folder
4. Press Play to start the game

### Building the Game

1. Go to File > Build Settings
2. Select your target platform
3. Click "Build" to create an executable

---

**Enjoy playing Flarpy-Blorb!** 🎉

_Made with ❤️ using Unity_
