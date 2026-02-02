# StreamongUS v1.0.0 - Initial Release

## 🎉 First Release

This is the first official release of **StreamongUS**, a client-side mod for Among Us (Xbox PC Game Pass) that helps prevent stream sniping by changing your impostor name color from red to white during meetings.

## ✨ Features

- **Stream-Safe**: Hides the red impostor name color that could reveal your role to stream viewers
- **Client-Side Only**: Changes are only visible to you, doesn't affect gameplay or other players
- **Non-Intrusive**: Only modifies visual display during meetings, no game logic changes
- **Easy to Use**: Just install and play - no configuration needed

## 🎮 What It Does

When you're the impostor and a meeting is called:
- **Normally**: Your name appears in **red** on the voting screen
- **With StreamongUS**: Your name appears in **white** instead
- **Result**: Stream viewers can't see you're the impostor from the name color

## 📋 Requirements

- **Among Us** (Xbox PC Game Pass version)
- **BepInEx IL2CPP** version 6.x - [Download here](https://github.com/BepInEx/BepInEx/releases)

## 📥 Installation

1. Install BepInEx IL2CPP in your Among Us game directory
2. Download `StreamongUS.dll` from this release
3. Place the DLL in `BepInEx/plugins/` folder
4. Launch the game and enjoy stream-safe gameplay!

For detailed installation instructions, see [INSTALLATION.md](https://github.com/DhyanCanPlay/StreamongUS/blob/main/INSTALLATION.md)

## 🔧 Building from Source

If you prefer to build from source:

```bash
git clone https://github.com/DhyanCanPlay/StreamongUS.git
cd StreamongUS
dotnet restore
dotnet build -c Release
```

The compiled DLL will be in `bin/Release/netstandard2.1/StreamongUS.dll`

For more details, see [BUILD.md](https://github.com/DhyanCanPlay/StreamongUS/blob/main/BUILD.md)

## 📚 Documentation

- [README.md](https://github.com/DhyanCanPlay/StreamongUS/blob/main/README.md) - Project overview
- [INSTALLATION.md](https://github.com/DhyanCanPlay/StreamongUS/blob/main/INSTALLATION.md) - Step-by-step installation guide
- [BUILD.md](https://github.com/DhyanCanPlay/StreamongUS/blob/main/BUILD.md) - Building from source
- [IMPLEMENTATION.md](https://github.com/DhyanCanPlay/StreamongUS/blob/main/IMPLEMENTATION.md) - Technical implementation details
- [VISUAL_GUIDE.md](https://github.com/DhyanCanPlay/StreamongUS/blob/main/VISUAL_GUIDE.md) - Visual guide with screenshots

## ⚙️ Compatibility

- **Game Version**: Among Us 2024.3.5 or compatible versions
- **Platform**: Xbox PC Game Pass
- **BepInEx**: 6.x IL2CPP
- **Framework**: .NET Standard 2.1

## ⚠️ Disclaimer

This is a client-side visual modification only. Use at your own discretion and in accordance with the game's terms of service. This mod:
- Does NOT provide any gameplay advantages
- Does NOT modify game files permanently
- Does NOT affect other players
- Is intended solely to prevent stream sniping

## 📄 License

MIT License - See [LICENSE](https://github.com/DhyanCanPlay/StreamongUS/blob/main/LICENSE) file for details

## 🙏 Acknowledgments

- BepInEx team for the excellent modding framework
- Among Us developers for creating an amazing game
- The modding community for inspiration and support

## 💬 Support

If you encounter any issues or have questions:
- Check the documentation files in the repository
- Review the [VISUAL_GUIDE.md](https://github.com/DhyanCanPlay/StreamongUS/blob/main/VISUAL_GUIDE.md) for troubleshooting
- Open an issue on [GitHub](https://github.com/DhyanCanPlay/StreamongUS/issues)

---

**Thank you for using StreamongUS! Happy streaming! 🎬**
