<style>
table, td{
    border: 1px solid black;
}
</style>

<h1>CSC458_Project1</h1>

<h2>Objectives:</h2>

<p>To test students’ knowledge of the following Unity topics:</p>

<table>

<tr>
    <td>Movement and rotation via any method</td>
    <td>Using the Terrain tool in Unity/ using Textures</td>
</tr>

<tr>
    <td>Collisions and Triggers</td>
    <td>Populating the game with beautiful assets from online stores + correct citations</td>
</tr>

<tr>
    <td>Instantiating and Destroying game objects</td>
    <td>Particle Systems</td>
</tr>

<tr>
    <td>UI in Unity</td>
    <td>Animations</td>
</tr>

<tr>
    <td>Serialization of variables & classes</td>
    <td>Scene management</td>
</tr>

<tr>
    <td>Camera follow - 1st person perspective</td>
    <td>Coroutines</td>
</tr>

<tr>
    <td>Sounds</td>
    <td>Raycasting</td>
</tr>

<tr>
    <td>User Input from the Keyboard and the Mouse</td>
    <td>Game Design Document & Technical Design Document</td>
</tr>

</table>

<h2>Requirements:</h2>

<ul>
    <li>The genre for your game will be a First-Person Shooter. This is a very classical genre with plenty of material available online. We covered and we will cover topics pertaining to this genre. Please pay attention and make sure you do nor commit academic misconduct or plagiarism. No need to plagiarize and thus take zero.</li>
    <br>
    <li>You have the freedom to pick a theme from a list of themes that I will give to the class. The theme will govern literally the assets chosen in your game world. Example: choosing the Medieval Europe theme means that maybe you will use a bow and arrow as a shooting mechanism and the environment could a castle in a forest or a medieval town etc...</li>
    <br>
    <li>The game will have only one level in project 1. You can add more meaningful complete levels to get bonus grades.</li>
    <br>
    <li>The map of the world should be created using the Terrain tool in Unity. You can also include buildings. Esthetically pleasing terrains with different terrains features and painted vegetation or using different textures (desert, Rocky Mountains etc...) will get higher grade on this requirement.</li>
    <br>
    <li>The map of the world should contain monuments and features that are pertinent to your theme.</li>
    <br>
    <li>Models and other assets can be acquired from free resources online as long as you mention their sources.</li>
    <br>
    <li>The game world map will feature several elements such as ammo pickups, monuments, obstacles and
    others according to the theme chosen. Esthetically pleasing games will get additional grades.</li>
    <br>
    <li>Movement and rotation of your character should be in the First person perspective only. You can use any movement/rotation method that you want including using components such as transform, rigidbody or character controller. You are even allowed to use readymade First person character controllers such as the one that is available in Unity Asset store: Starter Assets - First Person Character Controller (Unity Technologies). Input should only be via Keyboard and mouse.</li>
    <br>
    <li>Your game must contain good amount of collision logic and triggers. Triggers can be used to set hidden game objects which when you pass though trigger something: turn on/off lights or set an explosion or sound an alarm. It is up to your imagination!</li>
    <br>
    <li>You need to instantiate and destroy objects. This could be things you shoot at in order to blow them and make them disappear or this could be enemies you kill or anything else.</li>
    <br>
    <li>When you shoot, there should be a small SFX (sound effect) played according to your theme. You might be shooting arrows, spears, bullets, lazer, Dartguns, poison darts etc... Grab some good SFX from online stores and use them. I need to see you control SFX via C# code.</li>
    <br>
    <li>You need to have an intuitive UI that shows the score, health and ammo. You need to be able to have more than 1 weapon and be able to change the weapons easily via certain Keyboard keys. Each weapon has a type of ammo and an initial quantity of ammo. Ammo boxes of each type of weapon should be scattered in the environment. You player can pick these pickup boxes and thus increase the ammo count of the corresponding weapon. Hint: Check Brakeys Health bar YouTube video that explains how to create a health bar. Change it a bit to suit your own theme. This would flex your muscles in UI design in Unity.</li>
    <br>
    <li>I need to see you use Raycasting to implement an effective shooting mechanism.</li>
    <br>
    <li>You need to create enemies of some sort depending on the theme you choose. Suppose if the theme is apocalyptic, you can have your enemies look like zombies that will attack you when you are in their attack range and when you shoot at them directly. Enemies must decrease your health when they attack you. Add an attack animation to your zombies so that the attack looks realistic.</li>
    <br>
    <li>Killing an enemy increases the score. When your health reaches 0 you die. On death, a UI menu should appear asking you whether to play again or to quit. These should be as buttons. Pressing play again reloads your scene, quitting exit the whole game. If you kill all your enemies a similar UI menu should appear which should congratulate you, show you your score and ask you whether you want to play again or quit.</li>
    <br>
    <li>Your game should contain particle system(s) in a meaningful way. Ideas: You can create a nice small effect particle system that appear briefly when bullets or lazer hit an object at the location of the hit or create a particle system for explosions or a fountain or anything really. Please I need to see that you are controlling the particle system via C# code in order to get the full grade of this requirement.</li>
    <br>
    <li>I need to see that you have used coroutines at least once in meaningful way to get the full grade of this requirement. Recall from the lecture on Coroutines that they are used to do tasks that spread over time or across different frames such as dimming slowly a light or fading slowly a color or moving an enemy slowly. There are many places where you can use these in your FPS game.</li>
    <br>
    <li>I need to see a good number of serialized variables so that your game can be tweaked from the Unity Editor (via inspectors).</li>
    <br>
    <li>Good coding style/ good usage of comments/ DRY code/good overall program hygiene. Kindly add to the serialized variables in the inspector tooltips (recall attribute Tooltip) to explain briefly what these variables change so that the TA would understand what your serialized fields actually do in the Inspector.</li>
</ul>