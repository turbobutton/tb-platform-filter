# tb-platform-filter
## A simple template for toggling features on different VR platforms.

### USAGE
1. Call TBPlatformFilter.SetQualitySettiongs() from any script that runs at startup.
2. Use TBPlatformFilter.GetQualityLevel() to access the quality level from anywhere, and change stuff based on the TBQuality level enum returned.

### OPTIONAL
Set up quality settings in Unity for each platform as necessary. Example settings are inline below. Uncomment the QualitySettings.SetQualityLevel() lines to use that feature.

The "TBCullByPlatform" script will let you quickly turn off GameObjects on certain platforms. Set lowestAllowed and highestAllowed
in the editor on each scene object or prefab that you want to toggle. See that script for more usage information.
