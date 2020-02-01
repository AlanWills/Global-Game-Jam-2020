using System.Collections;
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
        private Sprite icon;

        [SerializeField]
        private GameObject prefab;

        #endregion

        #region Properties and Fields

        public Sprite Icon
        {
            get { return icon; }
        }

        #endregion

        #region Instantiation

        public GameObject Instantiate()
        {
            return GameObject.Instantiate(prefab);
        }

        #endregion
    }
}