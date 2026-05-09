# U005_Proyecto_Sonrisas_VR

[English](README.en.md) | [Español](README.md)

## Resumen

**Proyecto Sonrisas VR** es una demo funcional VR desarrollada en Unity con C#, orientada a un público infantil. El proyecto combina un enfoque terapéutico, educativo y lúdico mediante una experiencia inmersiva con varias escenas, interacción con objetos, elementos guiados y pequeños retos dentro del entorno virtual.

La experiencia incluye interacción mediante controladores VR, UI en mundo 3D, audio espacial, feedback visual y sonoro, partículas, animaciones, NPCs, objetivos, escenas y menús. También incorpora enemigos representados como carteles que el jugador puede derrotar lanzándoles tomates.

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

- Experiencia VR enfocada a público infantil.
- Enfoque terapéutico, educativo y lúdico.
- Soporte para Oculus Rift.
- Build objetivo para Windows.
- VR Rig.
- Movimiento continuo.
- Giro suave.
- Giro por pasos.
- Interacción con manos/controladores.
- Agarrar y soltar objetos.
- Activación de objetos.
- Ray interaction.
- UI integrada en mundo 3D.
- Audio espacial.
- Feedback visual y sonoro.
- Partículas y animaciones.
- NPCs y elementos guiados.
- Sistema de objetivos.
- Sistema de escenas.
- Sistema de menú.
- Pausa.
- Consideraciones de accesibilidad y confort.
- Enemigos tipo cartel derrotables lanzando tomates.
- Varias escenas dentro de la experiencia.

## Visuales

> Pendiente de añadir capturas e imágenes finales.

Nombres previstos para el pack visual:

- `proyectosonrisas-logo.png`
- `proyectosonrisas-cover.png`
- `proyectosonrisas-banner.png`
- `proyectosonrisas-thumbnail-01-vr-scene.png`
- `proyectosonrisas-thumbnail-02-object-interaction.png`
- `proyectosonrisas-thumbnail-03-tomato-targets.png`
- `proyectosonrisas-thumbnail-04-comfort-design.png`

## Arquitectura

La lógica principal se divide en:

- `LevelSelector` — selección de escenas o niveles.
- `MovementToPortal` — movimiento o transición hacia portales.
- `SplineEditor` — edición y configuración de splines.
- `PropsRandomGenerator` — generación aleatoria de elementos o props.
- `Rail` — definición de raíles o rutas.
- `RailPositionerManager` — gestión de posiciones sobre raíles.
- `RailSelectorManagement` — selección y control de raíles.
- `SplineAdvanced` — lógica avanzada de splines.
- `SplineFollower` — seguimiento de trayectorias spline.
- `SplineMesh` — representación o generación de malla basada en spline.

## Código recomendado para revisar

- [`Project/Assets/Scripts/SplineEditor.cs`](./Project/Assets/Scripts/SplineEditor.cs)
- [`Project/Assets/Scripts/PropsRandomGenerator.cs`](./Project/Assets/Scripts/PropsRandomGenerator.cs)
- [`Project/Assets/Scripts/Rail.cs`](./Project/Assets/Scripts/Rail.cs)
- [`Project/Assets/Scripts/RailPositionerManager.cs`](./Project/Assets/Scripts/RailPositionerManager.cs)
- [`Project/Assets/Scripts/RailSelectorManagement.cs`](./Project/Assets/Scripts/RailSelectorManagement.cs)
- [`Project/Assets/Scripts/SplineAdvanced.cs`](./Project/Assets/Scripts/SplineAdvanced.cs)
- [`Project/Assets/Scripts/SplineFollower.cs`](./Project/Assets/Scripts/SplineFollower.cs)
- [`Project/Assets/Scripts/SplineMesh.cs`](./Project/Assets/Scripts/SplineMesh.cs)

## Build

Actualmente no hay una release pública disponible.

**Build próximamente.**

## Estado

**Demo funcional VR archivada.**

El proyecto cuenta con una base funcional de experiencia VR con varias escenas, interacción con objetos, sistema de objetivos, elementos guiados, enemigos tipo cartel, lanzamiento de tomates, UI en mundo 3D, audio espacial, feedback visual y sonoro, partículas, animaciones, sistema de menú y pausa.

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

Este proyecto me permitió practicar la configuración de un entorno VR en Unity, incluyendo VR Rig, controladores, locomoción, interacción con objetos y adaptación de la experiencia a un entorno inmersivo.

También me ayudó a trabajar interacción con objetos en 3D, UI en mundo 3D, audio espacial y feedback visual y sonoro específico para realidad virtual.

Además, el proyecto sirvió para explorar el diseño de una experiencia inmersiva orientada a público infantil, teniendo en cuenta accesibilidad, confort, claridad de interacción y objetivos guiados.

Por último, el trabajo con splines, raíles y generación de elementos me permitió practicar sistemas técnicos aplicados a recorrido, movimiento guiado y organización de escenas VR.
