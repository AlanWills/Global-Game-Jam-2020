using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Celeste.Collectables
{
    public class Collectable : ScriptableObject
    {
        #region Serialized Fields

        public string displayName;

        public Texture2D texture;

        #endregion
    }
}