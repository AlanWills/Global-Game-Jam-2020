using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Collectables
{
    public class CollectableManager : ScriptableObject
    {
        #region Serialized Fields
        
        [SerializeField]
        private List<Collectable> collectables = new List<Collectable>();

        #endregion

        #region Collection Functions

        public bool CanCollectItems(Collector collector)
        {
            foreach (Collectable collectable in collectables)
            {
                if (collectable.CanBeCollected(collector))
                {
                    return true;
                }
            }

            return false;
        }

        public void CollectItems(Collector collector)
        {
            foreach (Collectable collectable in collectables)
            {
                if (collectable.CanBeCollected(collector))
                {
                    // TODO: Collection
                }
            }
        }

        #endregion
    }
}
