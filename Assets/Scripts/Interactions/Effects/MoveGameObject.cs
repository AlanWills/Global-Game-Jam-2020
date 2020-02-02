using Celeste.Storage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Interactions.Effects
{
    public class MoveGameObject : Effect
    {
        #region Serialized Fields

        [SerializeField]
        private string gameObjectName = "";

        [SerializeField]
        private Vector3 targetPosition;

        #endregion

        #region Effect Implementation

        public override IEnumerator Do(InteractableManager interactableManager, InventoryManager inventoryManager)
        {
            GameObject gameObject = GameObject.Find(gameObjectName);
            gameObject.transform.localPosition = targetPosition;

            return null;
        }

        #endregion
    }
}
