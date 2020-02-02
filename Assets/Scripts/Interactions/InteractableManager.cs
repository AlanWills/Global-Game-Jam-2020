using Celeste.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Interactions
{
    [AddComponentMenu("Celeste/Interactions/Interactable Manager")]
    public class InteractableManager : MonoBehaviour
    {
        #region Serialized Fields

        [SerializeField]
        private InventoryManager inventoryManager;

        [SerializeField]
        private List<Interactable> initialInteractables = new List<Interactable>();

        [SerializeField]
        private Transform worldRoot;

        private Dictionary<Interactable, GameObject> interactableGameObjects = new Dictionary<Interactable, GameObject>();

        #endregion

        #region Unity Methods

        public void Start()
        {
            foreach (Interactable interactable in initialInteractables)
            {
                AddInteractable(interactable);
            }
        }

        #endregion

        #region Interact Methods

        private static bool CanInteract(GameObject interactable, Interactor interactor)
        {
            Collider2D interactableCollider = interactable.GetComponent<Collider2D>();
            Collider2D interactorCollider = interactor.GetComponent<Collider2D>();
            ColliderDistance2D colliderDistance = interactableCollider.Distance(interactorCollider);
            return colliderDistance.isOverlapped || colliderDistance.distance == 0;
        }

        public bool CanInteractWithInteractables(Interactor interactor)
        {
            foreach (KeyValuePair<Interactable, GameObject> interactablePair in interactableGameObjects)
            {
                if (CanInteract(interactablePair.Value, interactor))
                {
                    return true;
                }
            }

            return false;
        }

        public void InteractWithInteractables(Interactor interactor)
        {
            foreach (KeyValuePair<Interactable, GameObject> interactableGameObject in interactableGameObjects)
            {
                if (CanInteract(interactableGameObject.Value, interactor))
                {
                    interactableGameObject.Key.Interact(this, inventoryManager);
                }
            }
        }

        public void AddInteractable(Interactable interactable)
        {
            interactableGameObjects.Add(interactable, interactable.Instantiate(worldRoot));
        }

        public void RemoveInteractable(Interactable interactable)
        {
            if (interactableGameObjects.ContainsKey(interactable))
            {
                GameObject.Destroy(interactableGameObjects[interactable]);
                interactableGameObjects.Remove(interactable);
            }
        }

        #endregion
    }
}
