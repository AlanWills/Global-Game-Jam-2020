using Celeste.Interactions.Effects;
using Celeste.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;

namespace CelesteEditor.Interactions.Effect
{
    public class DestroyGameObjectEditor
	{
		#region Component Menu Creation

		[MenuItem("Assets/Create/Celeste/Effects/Destroy GameObject")]
		public static void Create()
		{
			ScriptableObjectUtility.CreateAsset<DestroyGameObject>();
		}

		#endregion
	}
}
