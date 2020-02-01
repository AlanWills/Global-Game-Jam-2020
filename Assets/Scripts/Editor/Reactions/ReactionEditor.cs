using Celeste.Reactions;
using Celeste.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;

namespace CelesteEditor.Reactions
{
    public class ReactionEditor
	{
		#region Component Menu Creation

		[MenuItem("Assets/Create/Celeste/Reactions/Reaction")]
		public static void Create()
		{
			ScriptableObjectUtility.CreateAsset<Reaction>();
		}

		#endregion
	}
}
