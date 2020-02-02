using Celeste.Coroutines;
using Celeste.Interactions.Effects;
using Celeste.Interactions.Requirements;
using Celeste.Reactions;
using Celeste.Storage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Interactions
{
    public class Interactable : ScriptableObject
    {
        #region Serialized Fields

        [SerializeField]
        private GameObject prefab;

        [SerializeField]
        private Reaction requirementsFailedReaction;

        [SerializeField]
        private List<Requirement> requirements = new List<Requirement>();

        [SerializeField]
        private List<Effect> effects = new List<Effect>();

        #endregion

        #region Instantiation

        public GameObject Instantiate(Transform parent = null)
        {
            return GameObject.Instantiate(prefab, parent);
        }

        #endregion

        #region Requirement and Effect Methods

        public void Interact(InteractableManager interactableManager, InventoryManager inventoryManager)
        {
            if (AreRequirementsMet(inventoryManager))
            {
                CoroutineManager.PerformCoroutine(DoEffects(interactableManager, inventoryManager));
            }
            else if (requirementsFailedReaction != null)
            {
                interactableManager.AddReaction(this, requirementsFailedReaction);
            }
        }

        private bool AreRequirementsMet(InventoryManager inventoryManager)
        {
            foreach (Requirement requirement in requirements)
            {
                if (!requirement.IsMet(inventoryManager))
                {
                    return false;
                }
            }

            return true;
        }

        private IEnumerator DoEffects(InteractableManager interactableManager, InventoryManager inventoryManager)
        {
            foreach (Effect effect in effects)
            {
                yield return effect.Do(interactableManager, inventoryManager);
            }
        }

        #endregion
    }
}
