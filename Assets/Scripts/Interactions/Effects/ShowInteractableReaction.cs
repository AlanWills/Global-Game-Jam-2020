using Celeste.Reactions;
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
    public class ShowInteractableReaction : Effect
    {
        #region Serialized Fields

        [SerializeField]
        private Interactable interactable;

        [SerializeField]
        private Reaction reaction;

        #endregion

        public override IEnumerator Do(InteractableManager interactableManager, InventoryManager inventoryManager)
        {
            interactableManager.AddReaction(interactable, reaction);

            // Emoji animation time + a bit
            yield return new WaitForSeconds(1.5f);
        }
    }
}
