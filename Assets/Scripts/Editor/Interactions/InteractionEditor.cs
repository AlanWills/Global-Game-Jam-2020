using Celeste.Collectables;
using Celeste.Interactions;
using Celeste.Utility;
using UnityEditor;

namespace CelesteEditor.Interactions
{
	public class InteractableEditor
	{
        #region Component Menu Creation

        [MenuItem("Assets/Create/Celeste/Interactions/Interactable")]
		public static void Create()
		{
			ScriptableObjectUtility.CreateAsset<Interactable>();
		}

		#endregion
	}
}
