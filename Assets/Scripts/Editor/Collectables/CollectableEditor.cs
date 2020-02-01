using Celeste.Collectables;
using Celeste.Utility;
using UnityEditor;

namespace CelesteEditor.Collectables
{
	public class CollectableEditor
	{
        #region Component Menu Creation

        [MenuItem("Assets/Create/Celeste/Collectables/Collectable")]
		public static void Create()
		{
			ScriptableObjectUtility.CreateAsset<Collectable>();
		}

		#endregion
	}
}
