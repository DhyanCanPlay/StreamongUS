# StreamongUS - Implementation Summary

## Overview
StreamongUS is a BepInEx mod for Among Us (Xbox PC Game Pass) that addresses stream sniping by changing the local player's impostor name color from red to white during meetings/voting screens.

## Implementation Details

### Core Functionality
The mod implements a Harmony patch that:
1. Hooks into `MeetingHud.Update()` method
2. Detects when the local player is an impostor
3. Finds the local player's name text element in the meeting UI
4. Changes the color from red (#FF0000) to white (#FFFFFF)
5. Only affects client-side rendering (other players see normal colors)

### Key Components

#### StreamongUSPlugin.cs
- Main plugin entry point
- Inherits from `BepInEx.Unity.IL2CPP.BasePlugin`
- Initializes Harmony and applies all patches
- Plugin GUID: `com.dhyancanplay.streamongus`

#### Patches/MeetingHudPatch.cs
- Harmony postfix patch for `MeetingHud.Update`
- Contains comprehensive null checks for stability
- Only processes during active meeting states (Discussion, Voted, NotVoted)
- Efficiently finds and updates only the local player's name

### Safety Features
- Null reference checks at every step
- Early returns to prevent unnecessary processing
- Only modifies local player's display (client-side only)
- Does not affect game logic or other players' views
- Break statement after finding local player to optimize performance

### Technical Specifications

**Target Platform:**
- Among Us on Xbox PC Game Pass
- Windows x64

**Dependencies:**
- BepInEx.Core 5.4.21
- BepInEx.Unity.IL2CPP 6.0.0-be.674
- AmongUs.GameLibs.Steam 2024.3.5
- 0Harmony (via BepInEx)

**Framework:**
- .NET Standard 2.1
- Unity IL2CPP

### Security Considerations

✅ **Code Security:**
- No security vulnerabilities detected (CodeQL analysis)
- No external network calls
- No file system modifications
- No sensitive data access

✅ **Game Integrity:**
- Client-side visual change only
- No modification to game logic
- No advantage in gameplay
- Does not affect other players

✅ **Privacy:**
- No telemetry or data collection
- No personal information accessed
- Operates entirely locally

### Compatibility

**Works With:**
- Among Us 2024.3.5 and compatible versions
- Xbox PC Game Pass installation
- BepInEx IL2CPP 6.x
- Online and offline modes

**Known Limitations:**
- Requires BepInEx to be properly installed
- May need updates for major game version changes
- Game Pass file permissions may require administrator access

### Installation Requirements

1. Among Us (Xbox PC Game Pass)
2. BepInEx 6.x IL2CPP
3. Proper file system permissions
4. Windows antivirus exceptions (if needed)

### Build Information

**Build Command:**
```bash
dotnet build -c Release
```

**Output:**
- `bin/Release/netstandard2.1/StreamongUS.dll`

**Installation Path:**
- `{AmongUsFolder}/BepInEx/plugins/StreamongUS.dll`

## Testing

### Verification Steps
1. Install mod in BepInEx plugins folder
2. Launch Among Us
3. Check BepInEx console for load confirmation
4. Play game until receiving impostor role
5. Call a meeting (emergency button or report body)
6. Verify local player name appears in white

### Expected Behavior
- **Before Mod:** Impostor names appear in red during meetings
- **After Mod:** Local impostor name appears in white
- **Other Players:** See normal red color (unchanged)
- **Crewmate Role:** No effect (mod only activates for impostors)

## Use Case

**Problem:** Stream snipers watch streamers' meetings and identify them as impostors by the red name color.

**Solution:** This mod changes only the streamer's view to show their name in white, preventing viewers from identifying their role.

**Result:** Streamer can play impostor without revealing their role to stream viewers.

## Documentation

Comprehensive documentation provided:
- **README.md** - Overview and quick start
- **INSTALLATION.md** - Detailed installation guide for Game Pass
- **BUILD.md** - Building from source instructions
- **LICENSE** - MIT License
- **This File** - Implementation details

## Maintenance

### Future Updates
Monitor for:
- Among Us game updates (may need patch adjustments)
- BepInEx updates
- Unity engine changes
- Community feedback

### Version Compatibility
Current version targets Among Us 2024.3.5. For newer versions:
1. Update `AmongUs.GameLibs.Steam` package version
2. Test patch functionality
3. Adjust code if API changes occurred
4. Update version number

## Credits

**Author:** DhyanCanPlay  
**Repository:** https://github.com/DhyanCanPlay/StreamongUS  
**License:** MIT

## Disclaimer

This mod is for personal use to prevent stream sniping. It provides no gameplay advantage and only modifies visual appearance for the local player. Use at your own discretion and in accordance with the game's terms of service.
