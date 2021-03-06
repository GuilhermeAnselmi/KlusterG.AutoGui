# KlusterG.AutoGui

Library developed to facilitate the use of native windows components, such as defining the cursor position, sending keyboard shortcuts, or simulating keyboard typing.

# Requirements
* .NET Core v6.0

# How To Import?

## NuGet
* Access the NuGet package manager in your project
* Click Search
* Search for KlusterG.AutoGui
* Install the latest version of the library

## Command Line
* Access the Package Manager Console
* Type the command ```Install-Package KlusterG.AutoGui -Version 1.2.0```

## .NET CLI
* Type the command ```dotnet add package KlusterG.AutoGui --version 1.2.0```

## Git Clone
* Click on Code and download in .zip (can be done in other ways, I'm saying the simplest).
* Extract the content somewhere where you can locate it later (it can be placed together with the project you want to use, even within the solution itself).
* Access the KlusterG.AutoGui project and compile it.
* After compiled, you will have the .dll inside the bin.Debug.net6.0 folder. Once that's done, open the project you want to import the library.
* In your project, you will have the Dependencies component, click with the right mouse button and go to "Add Project Reference...".
* Click on Browse and locate the .dll file that was generated by the library, select it and click on add, after that, click on OK and your project will already have the library loaded.

# Components and Functions

* Message(string title, string content)

  Comment: Send message on screen this user

  Return: Tuple<bool, string>

#

* MouseClick(MKeys key)

  Comment: Simulation of clicking this mouse

  Return: Tuple<bool, string>

#

* MouseDoubleClick(MKeys key)

  Comment: Simulation of dobule clicking this mouse

  Return: Tuple<bool, string>

#

* MousePress(MKeys key)

  Comment: Simulation of pressing mouse click

  Return: Tuple<bool, string>

#

* ReleaseMouse(MKeys key)

  Comment: Release mouse key pressed

  Return: Tuple<bool, string>

#

* ReleaseMouseKeys()

  Comment: Release all mouse keys

  Return: void

#

* SetCursorPosition(Mouse mouse)

  Comment: Move mouse cursor to X and Y positions

  Return: void

#

* GetCursorPosition()

  Comment: Get mouse position

  Return: Mouse

#

* Write(string text)

  Comment: Simulates keyboard typing

  Return: Tuple<bool, string>

#

* KeyClick(KKeys key)

  Comment: Simulates a single keyboard click

  Return: Tuple<bool, string>

#

* KeyPress(KKeys key)

  Comment: Press a keyboard key

  Return: Tuple<bool, string>

#

* ReleaseKey(KKeys key)

  Comment: Release the pressed key on the keyboard

  Return: Tuple<bool, string>

#

* ReleaseKeyboardKeys()

  Comment: Release the pressed key from the keyboard

  Return: void

#

* GetKeyPress()

  Comment: Get the key that was pressed

  Return: Tuple<bool, string>

#

* ReleaseAllKeys()

  Comment: Release all keys (keyboard and mouse)

  Return: void

#

* GetPixelColor(int X, int Y)

  Comment: Get the color of the pixel that was indicated

  PixelColor

#

* Wait(int time)

  Comment: Makes the whole process wait for the parameter time
  
  Return: void

#

* StartRoutine(List\<ModelRoutine\> routine)

  Comment: Reads a list from the ModelRoutine object that executes each index in sequence to execute Mouse or Keyboard simulation commands
  
  Return: bool, string

#

* StartProcedure(ModelProcedure procedure)

  Comment: Reads a ModelProcedure object that executes both mouse and keyboard commands.
  
  Return: bool, string

#
