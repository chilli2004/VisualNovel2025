# Sympathy for the Devil

*A Unity game prototype combining narrative sequences, rhythm-game interactions, and puzzle mechanics.*

**Game / portfolio:** https://www.jessyjieart.com/sympathy-for-the-devil

> **For Code Lab I review:** This repository is a **C# source-code extract** from my previous Unity project, not the full playable Unity project. It contains the recovered scripts and their Unity `.meta` files. Scenes, artwork, audio, dependencies, and project settings are **not** included, so it cannot be opened or run as a complete project by itself. I can share the original project separately if required and feasible.

## About this project and my role

I originally approached this project from a **game-design and interaction-design** perspective. I personally worked on:

- **Game mechanics and level design:** defining the intended interactions and how different sections of the game should work.
- **Unity scene and UI assembly:** setting up scenes and interface elements and integrating the project's visual and audio assets.
- **Testing and iteration:** playtesting interactions, identifying problems, troubleshooting with available resources, and adjusting parameters to improve behavior and timing.

I was learning Unity and C# during development. I relied on **tutorials and AI tools** to help implement C# functionality. I **cannot reliably reconstruct which individual lines, methods, or files** originated from me, a tutorial, or an AI tool. To avoid making unsupported claims, **I do not label specific code as independently authored by me**. Each `.cs` file has a provenance notice explaining this limitation; all executable code remains unchanged from the recovered archive.

My current programming background includes introductory JavaScript in p5.js/ICM and some C++ through Arduino. I can work with simple variables, conditions, and interaction logic, while I am still building fluency with arrays, functions, and Unity-specific C# systems. That is also why I want to study Code Lab I.

## Scripts included

The table describes **what the recovered code does**, *not* which code I independently wrote.

| Area | Relevant scripts | Functionality visible in source |
| --- | --- | --- |
| Narrative / dialogue | `Levels1_1.cs` | Dialogue progression and text display |
| Rhythm interactions | `Levels1_2/Levels1Key.cs`, `ShortNote.cs`, `LongNote.cs` | Input and note-related behavior |
| Rhythm UI and results | `Levels1_2/EnergyBar.cs`, `Winning.cs` | Energy bar and win-state behavior |
| Puzzle | `Levels2_3/Puzzle.cs`, `Levels2_3/Levels2_3.cs` | Drag interactions and puzzle progression |
| Animation / presentation | `Ne/PssingAn.cs`, `PssingOvera.cs`, `HomePage.cs` | Sprite presentation and UI transitions |
| Other systems | `Levels1Music.cs`, `Levels2_2/Levels2.cs`, `Levels2_3/Raw.cs`, etc. | Audio, input, video and transitions |

`Levels1_2/Levels1_2.cs` and `Levels2_3/CompletionPrompt.cs` are essentially Unity starter templates, not substantial examples of original programming.

## Code attribution and AI use

**Confirmed work by me:** gameplay and level-design decisions; Unity scene/UI/asset setup; testing, troubleshooting, and parameter adjustment.

**Assistance used:** coding tutorials and AI assistance during C# implementation. I cannot now provide an accurate percentage or line-by-line attribution between independent code, tutorial adaptations, and AI output because the original development history is no longer complete.

**What this does *not* mean:** the presence of a complex algorithm in this repository should not be read as evidence that I independently wrote or fully understood it during development. Likewise, a simple code fragment should not automatically be credited to me without evidence. I have deliberately avoided guessing.

For additional context, see [`CONTRIBUTIONS.md`](CONTRIBUTIONS.md). I can explain the game's design process and the Unity assembly, testing, and iteration work I personally performed.

## Repository structure

```text
Assets/
  _s/
    Levels1_2/
    Levels2_2/
    Levels2_3/
    Ne/
    *.cs
README.md
CONTRIBUTIONS.md
```

**Reviewing the scripts:** `Levels1_1.cs` illustrates the dialogue system; `Levels1_2/Levels1Key.cs` the rhythm system; `Levels2_3/Puzzle.cs` puzzle interactions; `Ne/PssingAn.cs` animation playback. These are examples of the recovered implementation, **not independent-code authorship claims**.

### Notes

- The recovered scripts have **not** been compiled or tested as part of this preparation.
- Unity `.meta` files were kept, and macOS sidecar files were excluded.
- To share a directly openable Unity project, the original `Assets/`, `Packages/`, and `ProjectSettings/` would need to be prepared separately.
