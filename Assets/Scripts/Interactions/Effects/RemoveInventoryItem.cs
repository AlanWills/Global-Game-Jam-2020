using Celeste.Collectables;
using Celeste.Interactions;
using Celeste.Interactions.Effects;
using Celeste.Storage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace CelesteEngine.Interactions.Effects
{
    public class RemoveInventoryItem : Effect
    {
        #region Serialized Fields

        [SerializeField]
        private Collectable collectable;

        #endregion

        #region Effect Implementation Methods

        public override IEnumerator Do(InteractableManager interactableManager, InventoryManager inventoryManager)
        {
            inventoryManager.RemoveInventoryItem(collectable);

            return null;
        }

        #endregion
    }
}
