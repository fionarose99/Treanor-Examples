# CSC 470 - Game Programming - Unity Basics

Below is a list of topics that are demonstrated in the two example scenes (CatMovesTowardTree.unity and CorgiHotDogChase.unity). Download and import the [Basics.unitypackage](https://github.com/mtreanor/csc470-fall2019/blob/master/Basics/Basics.unitypackage), and inspect the project to make sure you understand everything. Come to class with questions!

* Creating and modfying 3d primitive shapes in the Unity Editor
* Creating and then applying materials to Game Objects
* Changing the background color by editing the Main Camera's clear flag and background color
* Applying and configuring Rigidbody Physics components
* Creating and applying custom components to Game Objects
* Response to player input (Input.GetKeyDown(), Input.GetKey(), Input.GetAxis())
* Making use of a game object transform's 'forward' vector
* Computing the vector between two objects (and normalizing it)
* Scaling a movement vector by Time.deltaTime (through multiplication) in order to ensure smooth continuous movement
* Using GameObject.Find() to get references to other game objects in your scene
* Directly giving a custom component a reference to another game object by declaring a 'public GameObject' variable in your comonent, and assigning the value to that reference in the Unity Editor (Inspector)
* Creating text user interface elements
* Downloading and applying custom fonts to Text objects
* Downloading and importing 3D models from Google Poly
* Positioning an object's origin by creating empty game objects, and repositioning 'child' objects (this is sometimes necessary with many Google Poly models)
* Creating and configuring colliders (all game objects need to have a collider in order for Unity to recognize collisions - primitive 3d shapes have these by default, but imported Google Poly models need you to manually apply one)
* Creating prefabs
* Instantiating prefabs
* Triggers: Making it so the OnTriggerEnter function is called when two objects collide (both objects need colliders, at least on of the colliders must be marked as a "Trigger", and at least one of the objects needs to have a RigidBody component - you will often want to remove gravity and mark it as kinematic)
* The timer pattern: Create a float variable with a value of the time you want to count down from. Decrease that variable by Time.deltaTime in your Update function. When that variable is less than zero, perform the action you want to have happen, and reset the countdown variable.