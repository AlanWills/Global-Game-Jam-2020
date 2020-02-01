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
        private Texture2D texture;

        [SerializeField]
        private GameObject gameObject;

        #endregion

        #region Collection Methods

        public bool CanBeCollected(Collector collector)
        {
            return gameObject.GetComponent<Collider2D>().Distance(collector.GetComponent<Collider2D>()).isOverlapped;
        }

        #endregion
    }
}