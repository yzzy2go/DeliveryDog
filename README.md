# DeliveryDog
A simple WebGL infinite runner made using Unity and C#.

It can be played here:
[Play Delivery Dog](https://play.unity.com/mg/other/delivery-dog)

## Core Mechanics

### Score
Scoring is based on how long the player is able to survive. In-game, players can see their score increase in the upper-left corner. After running into an obstacle, the game-over screen also shows the score they were able to reach. To add some difficulty, the camera slowly speeds up over time to test the player's reaction speed. 

### Obstacles
Obstacles in game take the form of wooden boxes that block the dogs path. If a player collides with one of these, well, it's game over!

### Replay
The game-over screen features a prompt to "Restart" the game if a player ever wants to beat their previous scores.

## Development

On starting the game, the main menu scene is loader by SceneManager. Pressing "Play" loads the "Game" scene and the game begins.

### Collisions

Obstacles are given the tag of "Enemy" and are constantly spawned in from the right of the screen. A random value is chosen from between the maximum and minimum time between spawns to ensure that the player can jump and clear the obstacle, while also varying their placement. If the player hitbox collides with any obstacle, the rest are despawned. Obstacles are also despawned when they hit the left border of the game so that there isn't unnecessary garbage buildup. 

### Player Movement

The dog jumps with the use of the up arrow key or the spacebar. The down arrow key can be used for fast-falling. 

The player uses the Rigidbody2D class to define it's hitbox and associated physics such as jump velocity and gravity. The ground height is also defined so that the game can detect if the player is currently running or jumping. Depending on the player's action, the animation is changed.

If the player "dies", the player game object is destroyed, and this is the trigger to pause the background and bring up the "Game-Over" screen. 

### Visuals

The theme of a dog running through a city street was inspired by my interest in urban exploration and the joy dogs have when they're able to run as fast and far as they can. The original dog sprite was created by @dawnblairr and the background by twitter.com/GuttyKreum and are used with permission from the creators. 

To make them fit the purpose of the game, I created different dog sprites to make up the player's running, jumping, and rest animations. In addition, I extended and edited the colouration of the background to allow it to wrap on itself infinitely while the player is moving.

## Screenshots
Title Screen:

![DDTitle](https://github.com/yzzy2go/DeliveryDog/assets/52092038/f7954d90-0e1e-446e-9097-2b0015553292)

Game in Progress: 

![DDGame](https://github.com/yzzy2go/DeliveryDog/assets/52092038/97c156fa-88dc-47aa-b240-8926242fe7ad)

Game Over: 

![DDGameOver](https://github.com/yzzy2go/DeliveryDog/assets/52092038/eda19dfe-859c-469a-8fc0-6a60cf4427b6)
