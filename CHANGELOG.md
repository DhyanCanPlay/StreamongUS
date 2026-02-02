# Changelog

All notable changes to StreamongUS will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [1.0.0] - 2026-02-02

### Added
- Initial release of StreamongUS mod
- Client-side impostor name color change from red to white on meeting screen
- Harmony patch for `MeetingHud.Update` method
- Stream-safe feature to prevent stream sniping
- Support for Among Us (Xbox PC Game Pass version)
- Compatible with BepInEx IL2CPP 6.x
- Comprehensive documentation (README, BUILD, INSTALLATION, IMPLEMENTATION, VISUAL_GUIDE)

### Features
- Only affects local player's view (client-side only)
- Changes impostor name color to white (#FFFFFF) during meetings
- Non-intrusive - doesn't modify game logic or affect other players
- Prevents stream viewers from seeing the red impostor name

### Technical Details
- Built with .NET Standard 2.1
- Uses BepInEx plugin framework
- Harmony patching for game method interception
- Compatible with Among Us version 2024.3.5

[1.0.0]: https://github.com/DhyanCanPlay/StreamongUS/releases/tag/v1.0.0
