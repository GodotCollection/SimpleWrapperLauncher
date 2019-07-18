# SimpleWrapperLauncher

![GitHub All Releases](https://img.shields.io/github/downloads/UnleavenedEagle/SimpleWrapperLauncher/total.svg)

This application will run another application and exit if the other application exits, but not if it restarts.


This was made as a temporary solution for a bug in the Godot Engine where Steam would not count the hours spent in Godot:

https://github.com/godotengine/godot/issues/18233


## Usage:

Put SimpleWrapperLauncher.exe into the same directory as your application.

Rename the original application with the name <name>.exe to _<name>.exe
  
Rename SimpleWrapperLauncher.exe to the name of your application: <name>.exe
  

## In case of Godot:

You can usually find the binaries in "C:\Program Files (x86)\Steam\steamapps\common\Godot Engine".

There you will have to rename the existing godot.windows.opt.tools.64.exe to _godot.windows.opt.tools.64.exe

then put in and rename SimpleWrapperLauncher.exe to godot.windows.opt.tools.64 

then you will be able to launch Godot from Steam and it will count your hours.

## Extra notes

SimpleWrapperLauncher will pass through arguments as well.

This has been only tested on Windows, as the bug does not occur on Linux, but it might work if you compile it with Mono.
