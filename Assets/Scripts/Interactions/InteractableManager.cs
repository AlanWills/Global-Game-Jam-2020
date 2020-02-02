using Celeste.Reactions;
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
        private GameObject emojiPrefab;

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
            // Create a copy to allow interactables to remove themselves from effects
            Dictionary<Interactable, GameObject> interactables = new Dictionary<Interactable, GameObject>(interactableGameObjects);

            foreach (KeyValuePair<Interactable, GameObject> interactableGameObject in interactables)
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

        public void RemoveInteractable(Interactable interactable, bool destroyGameObject)
        {
            if (interactableGameObjects.ContainsKey(interactable))
            {
                if (destroyGameObject)
                {
                    GameObject.Destroy(interactableGameObjects[interactable]);
                }

                interactableGameObjects.Remove(interactable);
            }
        }

        public void AddReaction(Interactable interactable, Reaction reaction)
        {
            AddReaction(interactableGameObjects[interactable].transform, reaction);
        }

        public void AddReaction(Transform parent, Reaction reaction)
        {
            GameObject emoji = GameObject.Instantiate(emojiPrefab, parent);
            emoji.GetComponent<SpriteRenderer>().sprite = reaction.Sprite;
        }

        #endregion
    }
}
