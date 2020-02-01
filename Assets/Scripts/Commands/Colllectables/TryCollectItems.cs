using Celeste.Collectables;
using Celeste.Commands.Collectables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celeste.Commands.Colllectables
{
    public class TryCollectItems : ICollectableCommand
    {
        #region Properties and Fields

        private Collector collector;

        #endregion

        public TryCollectItems(Collector collector)
        {
            this.collector = collector;
        }

        #region ICollectableCommand Implementation

        public bool CanExecute(CollectableManager collectableManager)
        {
            return collectableManager.CanCollectItems(collector);
        }

        public void Execute(CollectableManager collectableManager)
        {
            collectableManager.CollectItems(collector);
        }

        #endregion
    }
}
