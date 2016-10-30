# Sky-Jump
Prefabs for Sky Jump

"rotate.cs" = script to spin an otherwise stationary platform

"Rotating Platform.prefab" = stationary cylindrical platform spinning in place

"Clouds.prefab" = plane with the cloud pattern that should be lined up to cut off the bottoms of the platforms.  The materials can change for this plane depending on the scene, but this should always be paired with the script that triggers a "game over" if the player falls off a platform and hits the plane

"Collectible.prefab" = a little spinning cube that disappears when a player runs into it

"Door.prefab" = right now just a rectangle that triggers a "success" when a player successfully reaches it

"Start.prefab" = stationary platform that the player starts the level on.  This prefab can also be used as the end stationary platform that the end-of-level door sits on, just make sure to rename it "End" in your scene to avoid confusion
