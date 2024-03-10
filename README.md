# Unity Cube Rotator Project

This Unity project is designed to showcase different cube rotation scenarios using Unity's API. The project consists of multiple scenes, each demonstrating a specific requirement outlined below.

## Scene 1: Basic Cube Rotation

This scene features a cube that accelerates to rotate left or right when the user presses the left or right arrows, respectively. When the user releases the arrows, the cube decelerates to rest. Rotation is frame-rate independent. Note: Physics should not be used in this scene.

## Scene 2: Cube Rotation Around Another Cube

In this scene, another cube rotates left or right around the first cube when the user presses the left or right arrows. The rate at which cubes rotate varies randomly when the game starts, utilizing the Unity API.

## Scene 3: Multiple Rotating Cubes

This scene contains exactly ten cubes, each individually rotating and also rotating around a different cube. The setup ensures uniqueness in the rotation of each cube.

## Scene 4: Dynamic Cube Naming

The fourth scene features a script that loops through the ten movable cubes and assigns them unique names when the scene starts. No hard-coded literal values (strings or numbers) are used, requiring creative solutions to achieve unique naming. (Used hashcode to achive this)

## Instructions for Running the Project

1. Clone or download the repository to your local machine.
2. Open the Unity project in the Unity Editor.
3. Navigate to the desired scene by clicking on the scene file in the project explorer.
4. Play the scene by clicking on the play button in the Unity Editor toolbar.
5. Follow the on-screen instructions to interact with the cubes as per the scene requirements.

## Notes
