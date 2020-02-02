using Celeste.Collectables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Celeste.Storage
{
    [AddComponentMenu("Celeste/Storage/Inventory Manager")]
    public class InventoryManager : MonoBehaviour
    {
        #region Serialized Fields

        [SerializeField]
        private Inventory inventory;

        [SerializeField]
        private Transform inventoryRoot;

        [SerializeField]
        private GameObject inventoryItemPrefab;

        private Dictionary<Collectable, GameObject> itemGameObjects = new Dictionary<Collectable, GameObject>();

        #endregion

        #region Inventory Management Methods

        public void AddToInventory(Collectable collectable)
        {
            inventory.AddToInventory(collectable);
            GameObject itemPrefab = GameObject.Instantiate(inventoryItemPrefab, inventoryRoot);
            itemPrefab.GetComponent<Image>().sprite = collectable.Icon;
        }

        public bool HasInventoryItem(Collectable collectable)
        {
            return inventory.HasItem(collectable);
        }

        #endregion
    }
}
