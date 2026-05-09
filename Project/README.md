# U005_Proyecto_Sonrisas_VR

[English](README.en.md) | [Español](README.md)

## Resumen

Demo funcional VR desarrollada en Unity con C#, orientada a público infantil y planteada como una experiencia terapéutica, educativa y lúdica.

El usuario participa en varias escenas inmersivas con interacción mediante controladores, objetos manipulables, elementos guiados, objetivos, NPCs y enemigos representados como carteles que pueden ser derrotados lanzándoles tomates.

## Tecnologías

- Unity
- C#
- XR Interaction Toolkit
- OpenXR
- Oculus Integration
- Sistema de físicas 3D de Unity
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

## Características principales

- Experiencia VR para Oculus Rift.
- Build objetivo para Windows.
- Enfoque infantil, terapéutico, educativo y lúdico.
- Varias escenas.
- VR Rig.
- Movimiento continuo.
- Giro suave y giro por pasos.
- Interacción con manos/controladores.
- Agarrar, soltar y activar objetos.
- Ray interaction.
- UI en mundo 3D.
- Audio espacial.
- Feedback visual y sonoro.
- Partículas y animaciones.
- NPCs y elementos guiados.
- Sistema de objetivos.
- Sistema de escenas.
- Sistema de menú.
- Pausa.
- Accesibilidad y confort.
- Enemigos tipo cartel derrotables mediante lanzamiento de tomates.

## Capturas

> Pendiente de añadir capturas finales.

Ruta prevista:

![Gameplay](../Media/screenshots/gameplay-01.png)

## Arquitectura

La lógica principal se divide en:

- `LevelSelector` — selección de escenas o niveles.
- `MovementToPortal` — transición o movimiento hacia portales.
- `SplineEditor` — edición y configuración de splines.
- `PropsRandomGenerator` — generación aleatoria de props.
- `Rail` — definición de raíles o rutas.
- `RailPositionerManager` — gestión de posiciones sobre raíles.
- `RailSelectorManagement` — selección y control de raíles.
- `SplineAdvanced` — lógica avanzada de splines.
- `SplineFollower` — seguimiento de trayectorias spline.
- `SplineMesh` — representación o generación de mallas basadas en splines.

## Código recomendado para revisar

[`PRJ_ProyectoSonrisas/Assets/Scripts/SplineEditor.cs`](./PRJ_ProyectoSonrisas/Assets/Scripts/SplineEditor.cs)
[`PRJ_ProyectoSonrisas/Assets/Scripts/PropsRandomGenerator.cs`](./PRJ_ProyectoSonrisas/Assets/Scripts/PropsRandomGenerator.cs)
[`PRJ_ProyectoSonrisas/Assets/Scripts/Rail.cs`](./PRJ_ProyectoSonrisas/Assets/Scripts/Rail.cs)
[`PRJ_ProyectoSonrisas/Assets/Scripts/RailPositionerManager.cs`](./PRJ_ProyectoSonrisas/Assets/Scripts/RailPositionerManager.cs)
[`PRJ_ProyectoSonrisas/Assets/Scripts/RailSelectorManagement.cs`](./PRJ_ProyectoSonrisas/Assets/Scripts/RailSelectorManagement.cs)
[`PRJ_ProyectoSonrisas/Assets/Scripts/SplineAdvanced.cs`](./PRJ_ProyectoSonrisas/Assets/Scripts/SplineAdvanced.cs)
[`PRJ_ProyectoSonrisas/Assets/Scripts/SplineFollower.cs`](./PRJ_ProyectoSonrisas/Assets/Scripts/SplineFollower.cs)
[`PRJ_ProyectoSonrisas/Assets/Scripts/SplineMesh.cs`](./PRJ_ProyectoSonrisas/Assets/Scripts/SplineMesh.cs)

## Build

Actualmente no hay una release pública disponible.

**Build próximamente.**

## Estado

**Demo funcional VR archivada.**

El proyecto incluye una base funcional para Oculus Rift con escenas VR, movimiento, giro, interacción con manos/controladores, ray interaction, objetos, objetivos, NPCs, carteles enemigos, lanzamiento de tomates, UI en mundo 3D, audio espacial, feedback, partículas, animaciones, menú y pausa.

Pendiente de posibles mejoras:

- Añadir más escenas.
- Añadir más objetos interactivos.
- Mejorar interacción con manos.
- Añadir tutorial de controles.
- Añadir opciones de confort.
- Añadir locomoción alternativa.
- Mejorar feedback visual.
- Mejorar audio espacial.
- Añadir guardado de progreso.
- Añadir menú inicial.
- Añadir más elementos narrativos.
- Optimizar rendimiento en VR.

## Aprendizajes

Este proyecto me permitió practicar la configuración de un entorno VR en Unity, incluyendo VR Rig, controladores, locomoción y adaptación de la interacción a realidad virtual.

También me sirvió para trabajar interacción con objetos en 3D, UI en mundo 3D, audio espacial y feedback visual y sonoro.

Además, el proyecto me ayudó a diseñar una experiencia inmersiva orientada a público infantil, teniendo presentes accesibilidad, confort, claridad de interacción y objetivos guiados.

Finalmente, el trabajo con splines, raíles y generación de props me permitió practicar sistemas técnicos aplicados a recorridos, movimiento guiado y organización de escenas.
