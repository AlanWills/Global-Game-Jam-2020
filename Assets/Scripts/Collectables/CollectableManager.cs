using Celeste.Commands;
using Celeste.Commands.Collectables;
using Celeste.Commands.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Collectables
{
    [AddComponentMenu("Celeste/Collectables/Collectable Manager")]
    public class CollectableManager : MonoBehaviour
    {
        #region Serialized Fields

        [SerializeField]
        private List<Collectable> initialCollectables = new List<Collectable>();

        [SerializeField]
        private Transform worldRoot;

        private Dictionary<Collectable, GameObject> collectableGameObjects = new Dictionary<Collectable, GameObject>();

        #endregion

        #region Unity Methods

        public void Start()
        {
            foreach (Collectable collectable in initialCollectables)
            {
                AddCollectable(collectable);
            }
        }

        #endregion

        #region Collection Methods

        private static bool CanBeCollected(GameObject collectable, Collector collector)
        {
            Collider2D collectableCollider = collectable.GetComponent<Collider2D>();
            Collider2D collectorCollider = collector.GetComponent<Collider2D>();
            ColliderDistance2D colliderDistance = collectableCollider.Distance(collectorCollider);
            return colliderDistance.isOverlapped || colliderDistance.distance == 0;
        }

        public bool CanCollectCollectables(Collector collector)
        {
            foreach (KeyValuePair<Collectable, GameObject> collectablePair in collectableGameObjects)
            {
                if (CanBeCollected(collectablePair.Value, collector))
                {
                    return true;
                }
            }

            return false;
        }

        public void CollectCollectables(Collector collector)
        {
            foreach (KeyValuePair<Collectable, GameObject> collectableGameObject in collectableGameObjects)
            {
                if (CanBeCollected(collectableGameObject.Value, collector))
                {
                    CommandManager.QueueCommand(new RemoveCollectableFromScene(collectableGameObject.Key));
                    CommandManager.QueueCommand(new AddCollectableToInventory(collectableGameObject.Key));
                }
            }
        }

        public void AddCollectable(Collectable collectable)
        {
            collectableGameObjects.Add(collectable, collectable.Instantiate(worldRoot));
        }

        public void RemoveCollectable(Collectable collectable)
        {
            if (collectableGameObjects.ContainsKey(collectable))
            {
                GameObject.Destroy(collectableGameObjects[collectable]);
                collectableGameObjects.Remove(collectable);
            }
        }

        #endregion
    }
}
