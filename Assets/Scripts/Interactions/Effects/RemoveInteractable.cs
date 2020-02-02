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
    public class RemoveInteractable : Effect
    {
        #region Serialized Fields

        [SerializeField]
        private Interactable interactable;

        #endregion

        public override IEnumerator Do(InteractableManager interactableManager, InventoryManager inventoryManager)
        {
            interactableManager.RemoveInteractable(interactable);

            return null;
        }
    }
}
