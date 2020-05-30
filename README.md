# Monster Train Modding Resources

This repo holds a bunch of sample code regarding modding Monster Train. Feel free to use, reference, or modify it as you like.

## Getting Started

Install [BepInEx](https://github.com/BepInEx/BepInEx/releases) by extracting the files to your game's root folder (the one with the executable). The BepInEx folder and the MonsterTrain_Data folder should be on the same level.

Run the game, and BepInEx will generate a bunch of files in its own folder. If you're a developer, it is recommended that you go into BepInEx's config folder and enable the console at this point; it'll help immensely with debugging.

Now you can create a new Visual Studio project, or use the sample project in this repo as a base. If you make your own, select "Class Library (.NET Standard)" as the project template. If you use this project as a base, clone it into the game's root folder. Once open, you should add the following references to your project:

In BepInEx/core:
	
- BepInEx.dll
- BepInEx.Harmony
- 0Harmony.dll
	
In MonsterTrain_Data/Managed:
	
- UnityEngine
- UnityEngine.CoreModule
- UnityEngine.UI

Build the project and put your mod's .dll in BepInEx's plugins folder. The .dll can be in a subfolder of the plugins folder; as long as it's somewhere in there, BepInEx will find it, and it will load automatically when you run the game. You can configure the Visual Studio project to automatically put your .dll in the plugins folder on build through the project properties.

Note that the annotations on classes in the sample project are meaningful; if you do not provide them, your plugin will not work. If in doubt, use the sample project in this repo as a base.

Currently it seems as though [Harmony](https://harmony.pardeike.net/index.html) will be the centerpiece of the modding scene. You can reference the documentation for it [here](https://harmony.pardeike.net/articles/intro.html). Note that Harmony is included with BepInEx; there is no need to download it yourself.

Harmony allows you to inject code just about anywhere in the Monster Train codebase. The best way to find where you want to inject code is by decompiling the Assembly-CSharp.dll in MonsterTrain_Data/Managed and looking through the codebase for the appropriate method. One popular tool for doing this is [dnSpy](https://github.com/0xd4d/dnSpy), but there are several other options out there.

## Working Mods

The list of currently working mods can be found [here.](https://github.com/KittenAqua/MonsterTrainModding/wiki/Working-Mods)

## License
[MIT](https://choosealicense.com/licenses/mit/)
