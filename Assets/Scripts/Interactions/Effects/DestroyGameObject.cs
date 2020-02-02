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
    public class DestroyGameObject : Effect
    {
        #region Serialized Fields

        [SerializeField]
        private string gameObjectName;

        #endregion

        public override IEnumerable Do(InteractableManager interactableManager, InventoryManager inventoryManager)
        {
            GameObject.Destroy(GameObject.Find(gameObjectName));

            return null;
        }
    }
}
