using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Reactions
{
    public class Reaction : ScriptableObject
    {
        #region Serialized Fields

        [SerializeField]
        private Texture2D texture;

        #endregion
    }
}
