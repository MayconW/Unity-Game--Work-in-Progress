# Player Controller Script for Simple 2D RPG Game

This script is a Player Controller written in C# for a simple 2D RPG game developed in Unity. It handles basic player movement and attacking animations.

## Features

- **Movement:** Allows the player to move horizontally and vertically using arrow keys or similar input.
- **Animation:** Controls player animations based on movement and attack triggers.
- **Attacking:** Initiates an attack animation when the "Fire1" button (commonly left mouse click) is pressed.
- **Casting Spells:** Activates a casting animation when the space bar is pressed and deactivates it when released.

## Instructions

1. Attach this script to the player GameObject in your Unity scene.
2. Configure the `speed` variable to adjust the player's movement speed.
3. Customize animations and triggers in the associated Animator component according to your game's requirements.

## Usage

Feel free to use and modify this script in your 2D RPG game projects. If you encounter any issues or have suggestions for improvements, please create an issue or pull request.

## Usage Example

```csharp
// Example usage:
// Attach this script to a GameObject that represents the player character in a 2D RPG game.
// Customize playerAnimator, speed, and animations as needed.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // ... (rest of the provided script)
}
