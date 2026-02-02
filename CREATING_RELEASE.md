# How to Create the v1.0.0 Release

This guide explains the steps to create the first official release (v1.0.0) of StreamongUS.

## Overview

We have set up automated release workflows that will:
1. Build the project
2. Create release packages (DLL + ZIP)
3. Create a GitHub release with proper tags
4. Upload release artifacts

## Option 1: Manual Workflow (Recommended for First Release)

This is the easiest method and recommended for creating the first release.

### Steps:

1. **Navigate to GitHub Actions**
   - Go to: https://github.com/DhyanCanPlay/StreamongUS/actions
   - Click on "Manual Release" workflow in the left sidebar

2. **Run the Workflow**
   - Click the "Run workflow" button (on the right side)
   - A dropdown will appear with options:
     - **Branch**: Select `main` or the branch you want to release from
     - **Version number**: Enter `1.0.0`
     - **Is this a pre-release?**: Leave unchecked (for stable release)
   - Click the green "Run workflow" button

3. **Wait for Completion**
   - The workflow will take a few minutes to complete
   - You can monitor progress by clicking on the workflow run
   - Once complete, you'll see a green checkmark

4. **Verify the Release**
   - Go to: https://github.com/DhyanCanPlay/StreamongUS/releases
   - You should see "StreamongUS v1.0.0" release
   - Verify the files are attached:
     - `StreamongUS.dll`
     - `StreamongUS-v1.0.0.zip`

## Option 2: Using Git Tags

This method automatically triggers the release workflow when you push a tag.

### Steps:

1. **Ensure Your Local Repository is Up to Date**
   ```bash
   git checkout main
   git pull origin main
   ```

2. **Create a Git Tag**
   ```bash
   git tag -a v1.0.0 -m "Release version 1.0.0 - Initial stable release"
   ```

3. **Push the Tag to GitHub**
   ```bash
   git push origin v1.0.0
   ```

4. **Monitor the Workflow**
   - Go to: https://github.com/DhyanCanPlay/StreamongUS/actions
   - Watch the "Create Release" workflow execute
   - Wait for completion (green checkmark)

5. **Verify the Release**
   - Go to: https://github.com/DhyanCanPlay/StreamongUS/releases
   - Verify the release was created successfully

## Option 3: Manual Release via GitHub UI

If the automated workflows don't work, you can create a release manually.

### Prerequisites:
You'll need to build the DLL locally first:

```bash
git clone https://github.com/DhyanCanPlay/StreamongUS.git
cd StreamongUS
dotnet restore
dotnet build -c Release
```

The DLL will be in: `bin/Release/netstandard2.1/StreamongUS.dll`

### Steps:

1. **Go to Releases Page**
   - Navigate to: https://github.com/DhyanCanPlay/StreamongUS/releases

2. **Draft a New Release**
   - Click "Draft a new release"

3. **Create Tag**
   - Click "Choose a tag"
   - Type `v1.0.0` and press Enter
   - Select "Create new tag: v1.0.0 on publish"

4. **Fill Release Information**
   - **Release title**: `StreamongUS v1.0.0`
   - **Description**: Copy and paste the content from `RELEASE_NOTES.md`

5. **Upload Files**
   - Drag and drop or click to upload:
     - `StreamongUS.dll`
     - Create a ZIP with: DLL, README.md, INSTALLATION.md, LICENSE

6. **Publish**
   - Ensure "Set as the latest release" is checked
   - Click "Publish release"

## What Happens After Release?

Once the release is created:

1. **Tag**: A git tag `v1.0.0` is created
2. **Release Page**: Available at https://github.com/DhyanCanPlay/StreamongUS/releases/tag/v1.0.0
3. **Latest Release Badge**: The badge in README.md will show "v1.0.0"
4. **Download Link**: Direct link: https://github.com/DhyanCanPlay/StreamongUS/releases/latest

## Verifying the Release

After creating the release, verify:

- [ ] Release appears on the releases page
- [ ] Tag `v1.0.0` exists in the repository
- [ ] `StreamongUS.dll` is downloadable
- [ ] `StreamongUS-v1.0.0.zip` is downloadable (if using automated workflow)
- [ ] Release notes are properly formatted
- [ ] Badge in README.md shows the correct version
- [ ] "Latest release" badge works

## Troubleshooting

### Workflow Fails During Build

If the build fails due to missing dependencies:
- This is expected in GitHub Actions due to game-specific libraries
- Build locally instead and use Option 3 (Manual Release)

### Tag Already Exists

If you need to recreate the tag:
```bash
# Delete local tag
git tag -d v1.0.0

# Delete remote tag
git push origin :refs/tags/v1.0.0

# Recreate and push
git tag -a v1.0.0 -m "Release version 1.0.0"
git push origin v1.0.0
```

### Cannot Push Tag

Ensure you have write permissions to the repository.

## Next Steps After v1.0.0

For future releases:
1. Update version in `StreamongUS.csproj`
2. Update `CHANGELOG.md` with changes
3. Update `RELEASE_NOTES.md` with new information
4. Follow the same release process with the new version number (e.g., `v1.1.0`)

## Support

If you encounter issues:
- Check GitHub Actions logs for error messages
- Review the build output
- Consult `RELEASE_GUIDE.md` for detailed release procedures
- Open an issue on GitHub if problems persist

---

**Ready to create the release? Use Option 1 (Manual Workflow) for the easiest experience!**
