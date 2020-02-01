﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Celeste.Collectables
{
    public class Collectable : ScriptableObject
    {
        #region Serialized Fields

        [SerializeField]
        private string displayName;

        [SerializeField]
        private Texture2D texture;

        #endregion
    }
}