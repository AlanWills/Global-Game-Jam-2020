using Celeste.Collectables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Storage
{
    public class Inventory : ScriptableObject
    {
        #region Properties and Fields

        private List<Collectable> items = new List<Collectable>();

        #endregion

        #region Collectable Methods

        public void AddToInventory(Collectable collectable)
        {
            items.Add(collectable);
        }

        public bool HasItem(Collectable collectable)
        {
            return items.Exists(x => x == collectable);
        }

        #endregion
    }
}
