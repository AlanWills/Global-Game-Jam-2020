using Celeste.Utility;
using CelesteEngine.Interactions.Effects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;

namespace CelesteEditor.Interactions.Effect
{
    public class RemoveInventoryItemEditor
	{
		#region Component Menu Creation

		[MenuItem("Assets/Create/Celeste/Effects/Remove Inventory Item")]
		public static void Create()
		{
			ScriptableObjectUtility.CreateAsset<RemoveInventoryItem>();
		}

		#endregion
	}
}
