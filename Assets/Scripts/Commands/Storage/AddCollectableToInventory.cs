using Celeste.Collectables;
using Celeste.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Commands.Storage
{
    public class AddCollectableToInventory : IInventoryCommand
    {
        #region Properties and Fields

        private Collectable collectable;

        #endregion

        public AddCollectableToInventory(Collectable collectable)
        {
            this.collectable = collectable;
        }

        #region IInventoryCommand Implementation

        public bool CanExecute(InventoryManager inventoryManager)
        {
            return true;
        }

        public void Execute(InventoryManager inventoryManager)
        {
            Debug.Log(collectable.name + " added to inventory");
            inventoryManager.AddToInventory(collectable);
        }

        #endregion
    }
}
