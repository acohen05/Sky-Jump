# Sky-Jump
Prefabs for Sky Jump

"rotate.cs" = script to spin an otherwise stationary platform

"Rotating Platform.prefab" = stationary cylindrical platform spinning in place

"Clouds.prefab" = plane with the cloud pattern that should be lined up to cut off the bottoms of the platforms.  The materials can change for this plane depending on the scene, but this should always be paired with the script that triggers a "game over" if the player falls off a platform and hits the plane

"Collectible.prefab" = a little spinning cube that disappears when a player runs into it

"Collectible.cs" = the script that makes the little cube spin

"Door.prefab" = right now just a rectangle that triggers a "success" when a player successfully reaches it

"Start.prefab" = stationary platform that the player starts the level on.  This prefab can also be used as the end stationary platform that the end-of-level door sits on, just make sure to rename it "End" in your scene to avoid confusion.  This prefab can also be used as a spinning platform that spins in an orbit-like fashion if you give it the "SpinnerScript"

"SpinnerScript.cs" = creates orbiting-like behavior in the stationary platforms "start.prefab"

"PlayerController.cs" = (NEEDS A LOT OF EDITS TO APPROPRIATELY BEHAVE), controls various triggers in the game (if the player runs into a collectible, or a door, or the clouds, etc)
