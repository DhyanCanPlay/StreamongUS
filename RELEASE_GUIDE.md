# Release Guide

This document explains how to create releases for StreamongUS.

## Automated Release (Recommended)

### Method 1: Using GitHub Actions (Manual Workflow)

1. Go to the **Actions** tab in the GitHub repository
2. Select **"Manual Release"** workflow
3. Click **"Run workflow"**
4. Enter the version number (e.g., `1.0.0`)
5. Select if it's a pre-release or not
6. Click **"Run workflow"**

The workflow will:
- Build the project
- Create a git tag
- Create a GitHub release
- Upload the DLL and ZIP package

### Method 2: Creating a Git Tag (Automated Build)

```bash
# Create and push a version tag
git tag -a v1.0.0 -m "Release version 1.0.0"
git push origin v1.0.0
```

This triggers the automatic release workflow that builds and publishes the release.

## Manual Release

If you need to create a release manually:

### Prerequisites

1. .NET SDK 6.0 or later installed
2. Git command-line tools
3. Write access to the repository

### Steps

#### 1. Update Version Number

Edit `StreamongUS.csproj` and update the version:

```xml
<Version>1.0.0</Version>
```

#### 2. Update Documentation

Update `CHANGELOG.md` with the new version changes:

```markdown
## [1.0.0] - YYYY-MM-DD

### Added
- Feature 1
- Feature 2

### Changed
- Change 1

### Fixed
- Bug fix 1
```

Update `RELEASE_NOTES.md` with release information.

#### 3. Build the Project

```bash
# Restore dependencies
dotnet restore

# Build release version
dotnet build -c Release
```

The DLL will be in: `bin/Release/netstandard2.1/StreamongUS.dll`

#### 4. Create Release Package

```bash
# Create release directory
mkdir -p release

# Copy files
cp bin/Release/netstandard2.1/StreamongUS.dll release/
cp README.md release/
cp INSTALLATION.md release/
cp BUILD.md release/
cp LICENSE release/

# Create ZIP file
cd release
zip -r StreamongUS-v1.0.0.zip .
```

#### 5. Commit and Tag

```bash
git add .
git commit -m "Release v1.0.0"
git tag -a v1.0.0 -m "Release version 1.0.0"
git push origin main
git push origin v1.0.0
```

#### 6. Create GitHub Release

1. Go to the GitHub repository
2. Click on **"Releases"** → **"Draft a new release"**
3. Click **"Choose a tag"** and select `v1.0.0`
4. Set the release title: `StreamongUS v1.0.0`
5. Copy the content from `RELEASE_NOTES.md` into the description
6. Upload files:
   - `StreamongUS.dll`
   - `StreamongUS-v1.0.0.zip`
7. Check "Set as the latest release"
8. Click **"Publish release"**

## Version Numbering

Follow [Semantic Versioning](https://semver.org/):

- **MAJOR** version (X.0.0): Incompatible API changes
- **MINOR** version (0.X.0): New functionality, backwards compatible
- **PATCH** version (0.0.X): Bug fixes, backwards compatible

Examples:
- `1.0.0` - First stable release
- `1.1.0` - Added new features
- `1.1.1` - Fixed bugs
- `2.0.0` - Breaking changes

## Pre-releases

For pre-releases, use suffixes:

- `1.0.0-alpha.1` - Alpha version
- `1.0.0-beta.1` - Beta version
- `1.0.0-rc.1` - Release candidate

Mark pre-releases appropriately in GitHub.

## Checklist

Before creating a release:

- [ ] All tests pass
- [ ] Code builds without warnings
- [ ] Version number updated in `.csproj`
- [ ] `CHANGELOG.md` updated
- [ ] `RELEASE_NOTES.md` updated
- [ ] Documentation is up to date
- [ ] No uncommitted changes
- [ ] Tag follows semantic versioning

## Troubleshooting

### Build Fails

Ensure all dependencies are available:
```bash
dotnet restore --force
dotnet clean
dotnet build -c Release
```

### Cannot Push Tag

If the tag already exists:
```bash
git tag -d v1.0.0           # Delete local tag
git push origin :v1.0.0     # Delete remote tag
# Then create and push again
```

### Wrong Files in Release

Delete the release on GitHub, fix the files, and recreate the release.

## Release Workflow Summary

```
Update Version → Update Docs → Build Project → Create Package → 
Commit Changes → Create Tag → Push → Create GitHub Release
```

## Automated vs Manual

| Feature | Automated | Manual |
|---------|-----------|--------|
| Speed | Fast | Slow |
| Consistency | High | Variable |
| Control | Limited | Full |
| Effort | Low | High |

**Recommendation**: Use automated releases for regular releases, manual only for special cases.
