# FullSync
### A small mod that fixes some Vsync specific issues at the start of stages.

- This small change allows some strategies to be completely hardware independent (as some hardware just straight up can't use Vsync properly)
    - These include Minefield start, TTT start, etc.

## Installation
## Manual
1. Download [MelonLoader](https://github.com/LavaGang/MelonLoader/releases/latest) and install it onto your `Neon White.exe`.
2. Run the game once. This will create required folders.
3. Download `FullSync.dll` from the [Releases page](https://github.com/stxticOVFL/FullSync/releases/latest) and drop it in the `Mods` folder.
4. Optionally, download the **Mono** version of [Melon Preferences Manager](https://github.com/Bluscream/MelonPreferencesManager/releases/latest), and put the .DLLs from that zip into the `Mods` folder of your Neon White install.
    - The preferences manager is not required to use FullSync, but it does allow you to toggle it using the options menu (F5 by default).

### __*Automatic*__
This is not ready yet, and will be ready later.

~~**This mod is part of [White's Storage!](https://github.com/stxticOVFL/WhitesStorage)**~~
~~Follow the install instructions for that instead, and enable it in the `White's Storage` category in the preferences manager (F5 by default).~~

## Building & Contributing
This project uses Visual Studio 2022 as its project manager. When opening the Visual Studio solution, ensure your references are corrected by right clicking and selecting `Add Reference...` as shown below. 
Most will be in `Neon White_data/Managed`. Some will be in `MelonLoader/net35`, **not** `net6`. Select the `MelonPrefManager` mods for that reference. 
If you get any weird errors, try deleting the references and re-adding them manually.

![image](https://github.com/stxticOVFL/NeonCapture/assets/29069561/67c946de-2099-458d-8dec-44e81883e613)

Once your references are correct, build using the keybind or like the picture below.

![image](https://github.com/stxticOVFL/EventTracker/assets/29069561/40a50e46-5fc2-4acc-a3c9-4d4edb8c7d83)

Make any edits as needed, and make a PR for review. PRs are very appreciated.
