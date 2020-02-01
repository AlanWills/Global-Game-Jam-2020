using Celeste.Collectables;
using Celeste.Utility;
using UnityEditor;

namespace CelesteEditor.Collectables
{
	public class CollectableManagerEditor
	{
        #region Component Menu Creation

        [MenuItem("Assets/Create/Celeste/Collectables/Collectable Manager")]
		public static void Create()
		{
			ScriptableObjectUtility.CreateAsset<CollectableManager
						
				
				
				>();
		}

		#endregion
	}
}
