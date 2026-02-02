# Visual Guide - How StreamongUS Works

## Without Mod (Normal Behavior)

During a meeting/voting screen in Among Us:

```
╔══════════════════════════════════════╗
║        MEETING / VOTING              ║
╠══════════════════════════════════════╣
║                                      ║
║  👤 PlayerName1    [White Text]      ║
║  👤 PlayerName2    [White Text]      ║
║  👤 YourName       [RED TEXT]  ⚠️    ║  ← Reveals impostor!
║  👤 PlayerName4    [White Text]      ║
║  👤 PlayerName5    [White Text]      ║
║                                      ║
╚══════════════════════════════════════╝
```

**Problem:** When you're the impostor, YOUR name appears in RED. Stream viewers can see this and know you're the impostor! 🎮📺

## With StreamongUS Mod

During a meeting/voting screen with the mod installed:

```
╔══════════════════════════════════════╗
║        MEETING / VOTING              ║
╠══════════════════════════════════════╣
║                                      ║
║  👤 PlayerName1    [White Text]      ║
║  👤 PlayerName2    [White Text]      ║
║  👤 YourName       [White Text]  ✅   ║  ← Hidden from viewers!
║  👤 PlayerName4    [White Text]      ║
║  👤 PlayerName5    [White Text]      ║
║                                      ║
╚══════════════════════════════════════╝
```

**Solution:** With StreamongUS, YOUR name appears in WHITE (like crewmates). Stream viewers can't tell you're the impostor! 🎮📺✨

## Technical Implementation

### Color Values

| State | Without Mod | With Mod | Change |
|-------|------------|----------|--------|
| **Crewmate** | White (#FFFFFF) | White (#FFFFFF) | None |
| **Impostor (Others)** | Red (#FF0000) | Red (#FF0000) | None |
| **Impostor (You)** | Red (#FF0000) | **White (#FFFFFF)** | ✅ Changed |

### Code Flow

```
MeetingHud.Update() called every frame
           ↓
    Is meeting active? ──No──→ Exit
           ↓ Yes
    Is local player valid? ──No──→ Exit
           ↓ Yes
    Is local player impostor? ──No──→ Exit
           ↓ Yes
    Find local player's NameText
           ↓
    Set color to Color.white
           ↓
          Done
```

### Visual Comparison

#### Your Screen (With Mod)
```
Meeting Screen:
- Your Name: WHITE ⬜
- Other Impostors: RED 🟥 (if playing with multiple impostors)
- Crewmates: WHITE ⬜
```

#### Viewers' Screens (Watching Stream)
```
What they see:
- Your Name: WHITE ⬜
- Cannot distinguish you from crewmates
- Cannot tell you're the impostor! 🎉
```

#### Other Players' Screens
```
In their game:
- Your Name: RED 🟥 (unchanged for them)
- They can still see you're an impostor
- Mod only affects YOUR client
```

## Client-Side Only

The mod operates purely on **your client**:

```
┌─────────────┐        ┌─────────────┐        ┌─────────────┐
│  Your PC    │        │   Twitch    │        │   Viewer    │
│             │        │   Server    │        │   Browser   │
│ [MOD HERE]  │────────│             │────────│             │
│             │        │             │        │             │
│ Name: WHITE │ Stream │ Name: WHITE │  Show  │ Name: WHITE │
└─────────────┘────────└─────────────┘────────└─────────────┘
       ▲                                              
       │                                              
    Changes                                          
    here only                                        
```

```
┌─────────────┐        ┌─────────────┐        
│ Other Player│        │   Server    │        
│     PC      │────────│   (Game)    │        
│             │        │             │        
│ Name: RED   │ Normal │ Name: RED   │        
└─────────────┘────────└─────────────┘        
       ▲                                      
       │                                      
  Not affected                                
  by your mod                                 
```

## Example Scenario

### Situation
You're streaming Among Us and you're the impostor.

### Without Mod
1. Meeting is called 🚨
2. Your name appears in RED on YOUR screen 🟥
3. Stream viewers see the RED name 👀
4. They know you're the impostor! 😱
5. Some viewers might spoil it in chat or try to influence the game 😤

### With StreamongUS Mod
1. Meeting is called 🚨
2. Your name appears in WHITE on YOUR screen ⬜
3. Stream viewers see the WHITE name 👀
4. They think you're a crewmate! 🎭
5. No spoilers, fair gameplay continues! 😊

## Important Notes

### ✅ What This Mod DOES:
- Changes YOUR name color to white for YOU
- Changes YOUR name color to white for YOUR STREAM VIEWERS
- Prevents stream sniping
- Works during meetings/voting only

### ❌ What This Mod DOES NOT:
- Does NOT hide your name from other players
- Does NOT give gameplay advantages
- Does NOT affect server/network data
- Does NOT modify game logic
- Does NOT work for other impostors' names

### 🎯 Target Audience:
- Streamers playing Among Us
- Content creators
- Anyone who streams gameplay

### 🔒 Fair Play:
- No competitive advantage
- Visual change only
- Client-side modification
- Does not affect other players' experience

## Installation Quick View

```
Before Installation:
Among Us Folder/
├── Among Us.exe
└── ... game files

After BepInEx Installation:
Among Us Folder/
├── BepInEx/
│   ├── plugins/     ← Put StreamongUS.dll here
│   └── config/
├── Among Us.exe
└── ... game files

Final Result:
Among Us Folder/
├── BepInEx/
│   ├── plugins/
│   │   └── StreamongUS.dll  ✅
│   └── config/
├── Among Us.exe
└── ... game files
```

## Launch Verification

When you start Among Us with the mod:

```
BepInEx Console Window appears:
┌──────────────────────────────────────┐
│ [Info] BepInEx 6.0.0                 │
│ [Info] Loading plugins...            │
│ [Info] StreamongUS 1.0.0 loaded!     │ ✅
│ [Info] Applying Harmony patches...   │
│ [Info] All patches applied!          │ ✅
└──────────────────────────────────────┘
```

If you see these messages, the mod is working! 🎉
