using UnityEngine;
using System.Collections;
using TButt;

namespace TButt
{
    /// <summary>
    /// Destroys GameObjects that shouldn't be used on particular platforms.
    ///  
    /// USAGE: 
    /// 1. Set this script early on Unity's script execution order.
    /// 2. Add this component to a GameObject in the scene or a prefab.
    /// 3. Set the lowestAllowed and highestAllowed platforms via the editor.
    /// 4. Make sure TBPlatformFilter is getting initialized by one of your manager scripts earlier in the script execution order.
    /// 
    /// Lowest and highest allowed can be the same platform, if you wish to only have that object support on one platform.
    /// 
    /// Original Version 09/09 2015 by Turbo Button
    /// 
    /// </summary>
	public class TBCullByPlatform : MonoBehaviour {

		public TBQualityLevel lowestAllowed;
		public TBQualityLevel highestAllowed;

		private int qualityLevel;

		void Awake () 
		{
            qualityLevel = (int)TBPlatformFilter.GetQualityLevel();

			if(qualityLevel < (int)lowestAllowed)
			{
                DestroyImmediate(gameObject);
			}
			else if(qualityLevel > (int)highestAllowed)
			{
				DestroyImmediate(gameObject);
			}
		}
	}
}
