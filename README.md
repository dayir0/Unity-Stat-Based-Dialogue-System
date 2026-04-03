# 💬 Unity Stat-Based Dialogue System

![Unity Version](https://img.shields.io/badge/Unity-2021.3%2B-black?style=flat-square&logo=unity)
![License](https://img.shields.io/badge/License-MIT-blue?style=flat-square)
![C#](https://img.shields.io/badge/Language-C%23-green?style=flat-square)

A data-driven, RPG-style dialogue system for Unity. Inspired by classic RPGs like *Fallout* and *Baldur's Gate*, this system dynamically shows, hides, or locks dialogue options based on the player's current stats (e.g., Strength, Intelligence, Charisma).

## ✨ Features

* **Data-Driven Workflow:** Create complex branching dialogue trees using `ScriptableObjects` without writing a single line of code.
* **Stat Requirements:** Lock or unlock specific dialogue choices based on customizable player stats.
* **Adapter Pattern Ready:** Easily integrate the system into your *existing* character controllers and stat systems using the provided Connector script.
* **Visual Feedback:** Automatically greys out and locks dialogue buttons if the player doesn't meet the stat requirements.
* **UI Independent:** Fully compatible with Unity's UI and TextMeshPro.

## 📦 Getting Started

You have two options to integrate this system into your workflow:

### Option 1: Explore the Sample Project (Recommended)
If you want to see how the system works in a 3D environment with a Player and an NPC:
1. Download the repository as a **ZIP file**.
2. Extract it and open the folder via **Unity Hub** (`Add Project`).
3. Open the `DemoScene` and press Play. Walk up to the NPC and press `E` to interact!

### Option 2: Install via .unitypackage
If you want to import this system directly into your existing game:
1. Go to the [Releases](../../releases) page.
2. Download the `StatBasedDialogueSystem.unitypackage`.
3. Drag and drop the package into your Unity project and import all assets.

## 🛠️ How to Use

### 1. Creating a Dialogue Node
1. Right-click in your Project window.
2. Navigate to `Create > Dialogue > New Node`.
3. Enter the NPC's text and add your player `Options`.
4. (Optional) Set a `Requirement` (e.g., `Strength` minimum `15`) for an option.

### 2. Triggering the Dialogue
To start a dialogue from your own interaction scripts, simply call:
```csharp
FindObjectOfType<DialogueManager>().StartDialogue(yourDialogueNode);
```

### 3. Using Your Own Player Stats
Instead of using the default PlayerStats.cs, you can use the DialogueStatConnector.cs to bridge the dialogue system with your own existing player controller. Simply map your variables inside the CheckRequirement switch statement.

## 🤝 Contributing
Pull requests are welcome! For major changes, please open an issue first to discuss what you would like to change.

## 📜 License
This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---
> **🇹🇷 Türk Geliştiriciler İçin:**
> Bu sistemin nasıl çalıştığını ve kendi oyununuza nasıl entegre edebileceğinizi anlatan detaylı Türkçe kurulum rehberi için `Docs/Kurulum_Rehberi_TR.md` dosyasını inceleyebilirsiniz.
