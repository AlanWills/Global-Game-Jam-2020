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
    public class Delay : Effect
    {
        #region Serialized Fields

        [SerializeField]
        private float delay = 1;

        #endregion

        #region Effect Implementation

        public override IEnumerator Do(InteractableManager interactableManager, InventoryManager inventoryManager)
        {
            yield return new WaitForSeconds(delay);
        }

        #endregion
    }
}
