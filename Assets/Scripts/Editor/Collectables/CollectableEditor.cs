using Celeste.Collectables;
using Celeste.Utility;
using UnityEditor;

namespace CelesteEditor.Collectables
{
	[CustomEditor(typeof(Collectable))]
	public class CollectableEditor : Editor
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
