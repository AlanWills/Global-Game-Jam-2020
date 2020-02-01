using Celeste.Collectables;
using Celeste.Commands.Collectables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celeste.Commands.Collectables
{
    public class TryCollectCollectables : ICollectableCommand
    {
        #region Properties and Fields

        private Collector collector;

        #endregion

        public TryCollectCollectables(Collector collector)
        {
            this.collector = collector;
        }

        #region ICollectableCommand Implementation

        public bool CanExecute(CollectableManager collectableManager)
        {
            return collectableManager.CanCollectCollectables(collector);
        }

        public void Execute(CollectableManager collectableManager)
        {
            collectableManager.CollectCollectables(collector);
        }

        #endregion
    }
}
