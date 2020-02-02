using Celeste.Collectables;
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
    public class AddCollectable : Effect
    {
        #region Serialized Fields

        [SerializeField]
        private Collectable collectable;

        #endregion

        #region Effect Implementation

        public override IEnumerable Do(InteractableManager interactableManager, InventoryManager inventoryManager)
        {
            inventoryManager.AddToInventory(collectable);

            return null;
        }

        #endregion
    }
}
