# U005_Proyecto_Sonrisas_VR

[English](README.en.md) | [Español](README.md)

## Summary

Functional VR demo developed in Unity with C#, aimed at a child audience and designed as a therapeutic, educational and playful experience.

The user participates in several immersive scenes with controller-based interaction, manipulable objects, guided elements, objectives, NPCs and enemies represented as signs that can be defeated by throwing tomatoes at them.

## Technologies

- Unity
- C#
- XR Interaction Toolkit
- OpenXR
- Oculus Integration
- Unity 3D physics system
- Collider / Rigidbody
- Animator
- Particle System
- UI
- World Space UI
- AudioSource
- Lighting
- Post Processing
- Git LFS
- GitHub Releases

## Main features

- VR experience for Oculus Rift.
- Windows target build.
- Child-oriented, therapeutic, educational and playful approach.
- Several scenes.
- VR Rig.
- Continuous movement.
- Smooth turning and snap turning.
- Interaction with hands/controllers.
- Grab, release and activate objects.
- Ray interaction.
- World-space UI.
- Spatial audio.
- Visual and audio feedback.
- Particles and animations.
- NPCs and guided elements.
- Objective system.
- Scene system.
- Menu system.
- Pause.
- Accessibility and comfort.
- Sign-like enemies defeated by throwing tomatoes.

## Screenshots

> Final screenshots pending.

Planned path:

![Gameplay](./Media/screenshots/gameplay-01.png)

## Architecture

The main logic is divided into:

- `LevelSelector` — scene or level selection.
- `MovementToPortal` — transition or movement toward portals.
- `SplineEditor` — spline editing and configuration.
- `PropsRandomGenerator` — random prop generation.
- `Rail` — rail or route definition.
- `RailPositionerManager` — position management over rails.
- `RailSelectorManagement` — rail selection and control.
- `SplineAdvanced` — advanced spline logic.
- `SplineFollower` — spline path following.
- `SplineMesh` — mesh representation or generation based on splines.

## Recommended code to review

- [`Project/Assets/Scripts/SplineEditor.cs`](./Project/Assets/Scripts/SplineEditor.cs)
- [`Project/Assets/Scripts/PropsRandomGenerator.cs`](./Project/Assets/Scripts/PropsRandomGenerator.cs)
- [`Project/Assets/Scripts/Rail.cs`](./Project/Assets/Scripts/Rail.cs)
- [`Project/Assets/Scripts/RailPositionerManager.cs`](./Project/Assets/Scripts/RailPositionerManager.cs)
- [`Project/Assets/Scripts/RailSelectorManagement.cs`](./Project/Assets/Scripts/RailSelectorManagement.cs)
- [`Project/Assets/Scripts/SplineAdvanced.cs`](./Project/Assets/Scripts/SplineAdvanced.cs)
- [`Project/Assets/Scripts/SplineFollower.cs`](./Project/Assets/Scripts/SplineFollower.cs)
- [`Project/Assets/Scripts/SplineMesh.cs`](./Project/Assets/Scripts/SplineMesh.cs)

## Build

There is currently no public release available.

**Build coming soon.**

## Status

**Archived functional VR demo.**

The project includes a functional base for Oculus Rift with VR scenes, movement, turning, hand/controller interaction, ray interaction, objects, objectives, NPCs, sign-like enemies, tomato throwing, world-space UI, spatial audio, feedback, particles, animations, menu and pause.

Possible pending improvements:

- Add more scenes.
- Add more interactive objects.
- Improve hand interaction.
- Add a controls tutorial.
- Add comfort options.
- Add alternative locomotion.
- Improve visual feedback.
- Improve spatial audio.
- Add progress saving.
- Add an initial menu.
- Add more narrative elements.
- Optimize VR performance.

## Learnings

This project allowed me to practice setting up a VR environment in Unity, including VR Rig, controllers, locomotion and adapting interaction to virtual reality.

It also helped me work on 3D object interaction, world-space UI, spatial audio and visual/audio feedback.

In addition, the project helped me design an immersive experience aimed at a child audience, taking accessibility, comfort, interaction clarity and guided objectives into account.

Finally, working with splines, rails and prop generation allowed me to practice technical systems applied to paths, guided movement and scene organization.
