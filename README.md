# Bears

Open this project in unity. I have 2 examples to show. My assignment was to make the flamethrower to destroy terrain. So i first made a gun to experiment with destroying terrain. In the Assets theres a scene called "Guns". When you start this you will play the white circle and steer with "asdw" and shoot with mouse button 0, left click. Try shooting the rock!

Using the same method as the gun i wanted to "glue" this on the flame thrower. The flame it self consists of many small colliders. Each collider has a trigger. When a trigger is...triggered i have set it up to send a "callback". I made a callback function (i choosen a bad name :S ) that catches this trigger, and collects all the collider incidents. Then run through the incidents and instantiate an explotion that deletes terrain. 

The next version would instead of using an explotion, just "remove" terrain. The Explosion i use has this remove effect which is why i use it.

In order to test the flamethrower just open the scene "Pyro" in the assets folder. Start the game, control with "asdw" and shoot with mouse button 0. There is sound on this one and music :P  Notice that when you hold the button down, and shoot at the wall or rock the game slows down a great deal. This is because of the insane amount of colliders the flame sends out. My sollution for this will be to have 2 particle effects instead. One for show, and one invisible with the colliders. I have tried to reduce the colliders in the flame, but this seems to turn down the flame which is unwanted.

For Thursday unless you provide anything else for me to do im gonna set up interface for weapons, shoot method, move method, reload method etc, to easily implement future weapons.
