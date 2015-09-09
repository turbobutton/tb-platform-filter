using UnityEngine;
using System.Collections;

namespace TButt
{
    /// <summary>
    /// A simple manager for toggling features on different VR platforms.
    /// 
    /// Out-of-the-box support for Gear VR Note 4, Gear VR S6, PS4, and PC
    /// 
    /// USAGE: 
    /// 1. Call TBPlatformFilter.SetQualitySettiongs() from any script that runs at startup.
    /// 2. Use TBPlatformFilter.GetQualityLevel() to access the quality level from anywhere, and change your settings based on the 
    /// TBQuality level enum returned.
    /// 
    /// The "TBCullByPlatform" script will let you quickly turn off GameObjects on certain platforms. Set lowestAllowed and highestAllowed
    /// in the editor on each scene object or prefab that you want to toggle. See that script for more usage information.
    /// 
    /// OPTIONAL:
    /// Set up quality settings in Unity for each platform as necessary. Example settings are inline below. Uncomment the
    /// QualitySettings.SetQualityLevel() lines to use that feature.
    /// 
    /// Original Version 09/09 2015 by Turbo Button
    /// 
    /// </summary>
    public static class TBPlatformFilter 
    {
        private static TBQualityLevel quality; // do not delete this

	    public static void SetQualitySettings () 
        {
            // Gear VR Settings
            #if UNITY_ANDROID
                string gpu = SystemInfo.graphicsDeviceName;
                if ((gpu == "Adreno (TM) 420"))
                {
                    // Snapdragon Galaxy Note 4 Settings
                    quality = TBQualityLevel.MobileLow;
                    //QualitySettings.SetQualityLevel(0); 
                }
                else
                {
                    // Galaxy S6 (or better) Settings
                    quality = TBQualityLevel.MobileHigh;
                    //QualitySettings.SetQualityLevel(1);
                }
            #endif

            // PS4 Morpheus Settings
            #if UNITY_PS4
                quality = TBQualityLevel.QualityLevel.PCLow;
                //QualitySettings.SetQualityLevel(2);
            #endif

            // PC Settings
            #if UNITY_STANDALONE
                quality = TBQualityLevel.PC;
                //QualitySettings.SetQualityLevel(3);
            #endif
	    }

        public static TBQualityLevel GetQualityLevel()
        {
            return quality;
        }
    }
}

public enum TBQualityLevel
{
        MobileLow,
        MobileHigh,
        PS4,
        PC
}