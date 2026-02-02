# Installation Guide

## For Xbox PC Game Pass Users

### Prerequisites

1. **Among Us** installed via Xbox PC Game Pass
2. **BepInEx 6.x IL2CPP** - Download from [BepInEx Releases](https://builds.bepinex.dev/projects/bepinex_be)

### Step 1: Locate Your Among Us Installation

For Xbox PC Game Pass, Among Us is typically installed in:
```
C:\XboxGames\Among Us\Content\
```

Or you can find it by:
1. Open Xbox app
2. Right-click on Among Us
3. Select "Manage"
4. Click "Browse" to open the installation folder

### Step 2: Install BepInEx

1. Download **BepInEx 6.x IL2CPP** for Windows x64
2. Extract the BepInEx archive to your Among Us installation folder
3. Your folder structure should look like:
   ```
   Among Us/
   ├── BepInEx/
   │   ├── core/
   │   ├── plugins/
   │   └── config/
   ├── Among Us.exe
   └── ... other game files
   ```

4. Run Among Us once to let BepInEx initialize (you can close it after it starts)

### Step 3: Install StreamongUS

1. Download the latest `StreamongUS.dll` from the releases
2. Copy `StreamongUS.dll` to:
   ```
   Among Us/BepInEx/plugins/StreamongUS.dll
   ```

### Step 4: Verify Installation

1. Launch Among Us
2. Check the BepInEx console window (appears at startup) for:
   ```
   [Info   : StreamongUS] Plugin StreamongUS is loaded!
   [Info   : StreamongUS] All patches applied successfully!
   ```

3. If you don't see the console, check:
   ```
   BepInEx/LogOutput.log
   ```

### Step 5: Test the Mod

1. Start or join a game
2. Become the imposter (or wait until you get imposter role)
3. When a meeting is called, your name should appear in **white** instead of red
4. Other players will still see the normal colors - this is client-side only!

## Troubleshooting

### Game won't launch after installing BepInEx
- Make sure you downloaded the correct version (IL2CPP for Unity games)
- Verify all BepInEx files are in the correct location
- Check Windows permissions for the game folder

### Mod doesn't load
- Check `BepInEx/LogOutput.log` for errors
- Ensure `StreamongUS.dll` is in `BepInEx/plugins/`
- Verify BepInEx initialized correctly (console should appear)

### Name is still red
- The mod only works when YOU are the imposter
- Make sure the mod loaded successfully (check logs)
- The color changes during meetings/voting only

### Game Pass Specific Issues

**Permission Denied Errors:**
- Game Pass apps have restricted permissions
- Run the game as Administrator if needed
- Some antivirus software may block BepInEx

**Updates Breaking the Mod:**
- Game updates may require BepInEx updates
- Check for updated versions after game patches
- The mod may need recompilation for major game updates

## Uninstallation

To remove the mod:
1. Delete `BepInEx/plugins/StreamongUS.dll`

To remove BepInEx entirely:
1. Delete the entire `BepInEx` folder
2. Delete `doorstop_config.ini` and `winhttp.dll` from game root

## Game Pass Compatibility Notes

- Works with Game Pass version of Among Us
- Requires BepInEx IL2CPP build
- May need administrator privileges on first run
- Some antivirus software may flag BepInEx (false positive)
- Compatible with offline and online play

## Support

If you encounter issues:
1. Check the logs in `BepInEx/LogOutput.log`
2. Verify your game version is compatible
3. Ensure all steps were followed correctly
4. Report issues on the GitHub repository
