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
        private Sprite sprite;

        #endregion

        #region Properties and Fields

        public Sprite Sprite
        {
            get { return sprite; }
        }

        #endregion
    }
}
