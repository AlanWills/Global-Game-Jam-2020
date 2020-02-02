using Celeste.Collectables;
using Celeste.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Interactions.Requirements
{
    public class HasInventoryItem : Requirement
    {
        #region Properties and Fields

        [SerializeField]
        private Collectable collectable;

        #endregion

        #region Requirement Implementation

        public override bool IsMet(InventoryManager inventoryManager)
        {
            return inventoryManager.HasInventoryItem(collectable);
        }

        #endregion
    }
}
