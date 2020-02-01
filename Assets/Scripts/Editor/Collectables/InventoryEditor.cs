using Celeste.Storage;
using Celeste.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEditor;

namespace CelesteEditor.Storage
{
    public class InventoryEditor
    {
        #region Component Menu Creation

        [MenuItem("Assets/Create/Celeste/Collectables/Inventory")]
        public static void Create()
        {
            ScriptableObjectUtility.CreateAsset<Inventory>();
        }

        #endregion
    }
}
