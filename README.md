# StreamongUS

A mod for Among Us (Xbox PC Game Pass) that changes the local player's impostor name color from red to white on the voting/meeting screen to prevent stream sniping.

## Features

- **Client-side only**: Changes are only visible to you, not affecting gameplay or other players
- **Stream-safe**: Hides the red impostor name color that could give away your role to stream viewers
- **Non-intrusive**: Only affects visual display during meetings, doesn't modify game logic

## Installation

### Prerequisites

1. **Among Us** (Xbox PC Game Pass version)
2. **BepInEx IL2CPP** (version 6.x) - [Download here](https://github.com/BepInEx/BepInEx/releases)

### Steps

1. Install BepInEx IL2CPP in your Among Us game directory
2. Download the latest release of StreamongUS
3. Extract `StreamongUS.dll` to `BepInEx/plugins/` folder
4. Launch the game

## How It Works

When you're the impostor and a meeting is called:
- Normally, your name appears in **red** on the voting screen
- With this mod, your name appears in **white** instead
- This prevents stream viewers from seeing the red name and knowing you're the impostor

### Technical Details

The mod uses Harmony to patch the `MeetingHud.Update` method:
- Detects when local player is an impostor
- Locates the local player's name text in the meeting UI
- Changes the color to white (#FFFFFF)
- Only affects client-side rendering

## Building from Source

### Requirements

- .NET SDK 6.0 or later
- Among Us game libraries
- BepInEx libraries

### Build Steps

```bash
# Restore dependencies
dotnet restore

# Build the project
dotnet build -c Release
```

The compiled DLL will be in `bin/Release/netstandard2.1/StreamongUS.dll`

## Compatibility

- **Game Version**: Among Us 2024.3.5 or compatible versions
- **Platform**: Xbox PC Game Pass
- **BepInEx**: 6.x IL2CPP

## Notes

- This mod is for personal use to prevent stream sniping
- Does not provide any gameplay advantages
- Only changes visual appearance for the local player
- Compatible with Game Pass file structure and permissions

## Disclaimer

This is a client-side visual modification only. Use at your own discretion and in accordance with the game's terms of service.

## License

MIT License - See LICENSE file for details