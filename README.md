# 2D Platform Game
![Screenshot 2025-03-02 235218](https://github.com/user-attachments/assets/7b815f25-8a19-4301-80a9-0c1ffd755ad7)
![Screenshot 2025-03-02 235305](https://github.com/user-attachments/assets/5f2bbd5f-cf4d-4bdb-870f-26d66b73138c)
![Screenshot 2025-03-02 235234](https://github.com/user-attachments/assets/1fbd3e31-f516-493d-b820-240725cd5254)

## Overview
This is a simple 2D platformer game built using C# and Windows Forms. The game features a player (green skeleton) that moves and jumps to avoid enemies and obstacles, while collecting points and trying to reach the target/home. The game ends when the player collides with an enemy, the wire mesh, or the target/home. 

## Features
1. **Player**: The player is represented by a green skeleton. The player can move left, right, and jump.
2. **Enemy**: The enemy is represented by a red skeleton. It moves automatically back and forth within a specified range. The game ends if the player collides with the enemy.
3. **Platforms**: Horizontal black bars act as platforms where the player can stand. The player can jump from one platform to another.
4. **Wire Mesh**: Represented by a red wire mesh. Colliding with this mesh causes the game to end.
5. **Points**: Small yellow circles are placed throughout the game. The player earns 10 points for each collision with a point.
6. **Target/Home**: Represented by a circled black dot. The game ends with a "Game Won" status when the player collides with the target/home.
7. **Score and Time**: The game keeps track of the score (based on collected points) and time elapsed. Both are displayed on the screen.

## Game Flow and Logic
- The **player** moves using keyboard input (arrow keys to move, spacebar to jump).
- **Enemies** move back and forth automatically, and if they collide with the player, the game ends with a "Game Lost" message.
- **Wire Mesh**: The game ends if the player collides with the wire mesh, displaying a "Game Lost" message.
- **Points**: When the player touches a small yellow circle, they earn 10 points.
- **Target/Home**: If the player collides with the target/home (black dot), the game ends with a "Game Won" message.
- **Timer**: The game tracks time and displays it on the screen. If the player survives until the target/home, they win; otherwise, the game ends on collision.

## Setup and Installation
### Prerequisites
- **Microsoft Visual Studio** (or any compatible IDE that supports C# and Windows Forms).
  
### Steps to Run the Game
1. **Clone or Download the Project**:
   - Clone the repository or download the project folder and extract it to your local machine.
  
2. **Open the Project**:
   - Open the project file (`.csproj`) in **Microsoft Visual Studio**.

3. **Run the Application**:
   - Build and run the project using Visual Studio.

### Controls:
- **Move Left**: Left Arrow key
- **Move Right**: Right Arrow key
- **Jump**: Spacebar
- **Pause/Restart**: (If applicable, define key controls here)

## Game Components
### Player
- The player is represented by a **green skeleton**.
- The player can move left, right, and jump between platforms.
  
### Enemy
- The enemy is represented by a **red skeleton**.
- The enemy moves back and forth on a defined platform.
  
### Wire Mesh
- The wire mesh is represented by a **red wire mesh**.
- Colliding with the wire mesh causes the game to end with the message "Game Lost".

### Points
- Small **yellow circles** appear throughout the game.
- The player earns 10 points upon colliding with a yellow circle.

### Target/Home
- The **target** is represented by a **circled black dot**.
- The game ends with the message "Game Won" if the player collides with the target.

### Platform
- **Black horizontal bars** act as the platforms where the player can jump and land.
  
## Game Logic and Features
### Movement
- The player has horizontal speed and jump height controlled by player input (arrow keys and spacebar).
  
### Automatic Enemy Movement
- The enemy moves back and forth within a defined range, automatically adjusting its position as it reaches the limits.

### Gravity and Jump Mechanics
- The player is affected by gravity, falling after jumping.
  
### Timer
- The game has a countdown timer that runs from 1 to 15 seconds.
- The game ends either when the player reaches the target or when the timer expires.

### Score and Time
- The score is incremented by 10 points each time the player collides with a yellow point.
- The time elapsed is displayed during the game.

## Message Boxes
- Upon game completion:
  - **Game Won**: If the player reaches the target/home, a message box displays "Game Won".
  - **Game Lost**: If the player collides with the enemy or wire mesh, a message box displays "Game Lost".
