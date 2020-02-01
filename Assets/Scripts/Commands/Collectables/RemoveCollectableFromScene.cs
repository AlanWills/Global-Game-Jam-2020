using Celeste.Collectables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Commands.Collectables
{
    public class RemoveCollectableFromScene : ICollectableCommand
    {
        #region Properties and Fields

        private Collectable collectable;

        #endregion

        public RemoveCollectableFromScene(Collectable collectable)
        {
            this.collectable = collectable;
        }

        #region ICollectableCommand Implementation

        public bool CanExecute(CollectableManager collectableManager)
        {
            return true;
        }

        public void Execute(CollectableManager collectableManager)
        {
            Debug.Log(collectable.name + " removed from scene");
            collectableManager.RemoveCollectable(collectable);
        }

        #endregion
    }
}
