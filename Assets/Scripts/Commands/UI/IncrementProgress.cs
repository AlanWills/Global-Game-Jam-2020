using Celeste.Commands.UI;
using CelesteEngine.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celeste.Commands.UI
{
    public class IncrementProgress : IUICommand
    {
        #region Properties and Fields

        private float increment = 0;

        #endregion

        public IncrementProgress(float increment)
        {
            this.increment = increment;
        }

        #region IUICommand Implementation

        public bool CanExecute(UIManager uiManager)
        {
            return true;
        }

        public void Execute(UIManager uiManager)
        {
            uiManager.IncrementProgressBarFill(increment);
        }

        #endregion
    }
}
