# Building StreamongUS

This guide explains how to build the StreamongUS mod from source.

## Prerequisites

- **.NET SDK 6.0 or later** - [Download here](https://dotnet.microsoft.com/download)
- **Among Us Game Files** (for game libraries)
- **BepInEx Libraries** (automatically downloaded via NuGet)

## Quick Build

```bash
# Clone the repository
git clone https://github.com/DhyanCanPlay/StreamongUS.git
cd StreamongUS

# Restore dependencies
dotnet restore

# Build Release version
dotnet build -c Release
```

The compiled DLL will be located at:
```
bin/Release/netstandard2.1/StreamongUS.dll
```

## Setup for Development

### 1. Install Dependencies

The project uses NuGet packages that will be automatically restored:
- `BepInEx.Core` (5.x)
- `BepInEx.Unity.IL2CPP` (6.x)
- `AmongUs.GameLibs.Steam` (2024.3.5)

### 2. Configure NuGet Sources

The `NuGet.Config` file includes the BepInEx NuGet feed:
```xml
<PackageSources>
  <PackageSource key="nuget.org" value="https://api.nuget.org/v3/index.json" />
  <PackageSource key="BepInEx" value="https://nuget.bepinex.dev/v3/index.json" />
</PackageSources>
```

### 3. Build Configurations

**Debug Build:**
```bash
dotnet build -c Debug
```
- Includes debug symbols
- No optimizations
- Output: `bin/Debug/netstandard2.1/StreamongUS.dll`

**Release Build:**
```bash
dotnet build -c Release
```
- Optimized code
- No debug symbols
- Output: `bin/Release/netstandard2.1/StreamongUS.dll`

## Project Structure

```
StreamongUS/
├── StreamongUSPlugin.cs       # Main plugin entry point
├── Patches/
│   └── MeetingHudPatch.cs    # Harmony patch for meeting UI
├── StreamongUS.csproj         # Project configuration
├── NuGet.Config               # NuGet package sources
└── README.md                  # Documentation
```

## Development Workflow

1. **Make Changes** - Edit C# files in your IDE
2. **Build** - Run `dotnet build`
3. **Test** - Copy DLL to `BepInEx/plugins/` in your Among Us folder
4. **Debug** - Check `BepInEx/LogOutput.log` for errors

## IDE Setup

### Visual Studio
1. Open `StreamongUS.csproj`
2. Build → Build Solution (Ctrl+Shift+B)

### Visual Studio Code
1. Install C# extension
2. Open folder
3. Run task: `dotnet build`

### Rider
1. Open `StreamongUS.csproj`
2. Build → Build Solution

## Common Build Issues

### Missing NuGet Packages
```bash
dotnet restore --force
```

### Wrong .NET Version
Ensure .NET SDK 6.0+ is installed:
```bash
dotnet --version
```

### Among Us Libraries Not Found
The `AmongUs.GameLibs.Steam` package should provide these automatically. If you get errors, ensure NuGet restore completed successfully.

## Testing Your Build

1. Copy the compiled DLL:
   ```bash
   copy bin\Release\netstandard2.1\StreamongUS.dll "C:\XboxGames\Among Us\Content\BepInEx\plugins\"
   ```

2. Launch Among Us and check the BepInEx console

3. Look for:
   ```
   [Info   : StreamongUS] Plugin StreamongUS is loaded!
   [Info   : StreamongUS] All patches applied successfully!
   ```

## Contributing

When contributing:
1. Follow existing code style
2. Test your changes thoroughly
3. Update documentation if needed
4. Ensure build succeeds without warnings

## Version Compatibility

- **Target Framework**: .NET Standard 2.1
- **Among Us**: 2024.3.5 (may work with other versions)
- **BepInEx**: 6.x IL2CPP
- **Unity**: IL2CPP backend

## Troubleshooting Build Issues

### "Type or namespace 'BepInEx' could not be found"
- Run `dotnet restore`
- Check NuGet sources are configured correctly
- Try `dotnet nuget locals all --clear` then restore again

### "Type or namespace 'MeetingHud' could not be found"
- Ensure `AmongUs.GameLibs.Steam` package restored correctly
- Version may need updating for newer game versions

### Build succeeds but mod doesn't work
- Check game version compatibility
- Verify BepInEx is installed correctly
- Check logs for runtime errors
