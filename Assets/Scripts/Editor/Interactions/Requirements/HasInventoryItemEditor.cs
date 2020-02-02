using Celeste.Interactions.Requirements;
using Celeste.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;

namespace CelesteEditor.Interactions.Requirements
{
    public class HasInventoryItemEditor
	{
		#region Component Menu Creation

		[MenuItem("Assets/Create/Celeste/Requirements/Has Inventory Item")]
		public static void Create()
		{
			ScriptableObjectUtility.CreateAsset<HasInventoryItem>();
		}

		#endregion
	}
}
