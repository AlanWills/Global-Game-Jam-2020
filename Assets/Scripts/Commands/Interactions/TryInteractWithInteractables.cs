using Celeste.Collectables;
using Celeste.Commands.Collectables;
using Celeste.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celeste.Commands.Interactables
{
    public class TryInteractWithInteractables : IInteractableCommand
    {
        #region Properties and Fields

        private Interactor interactor;

        #endregion

        public TryInteractWithInteractables(Interactor interactor)
        {
            this.interactor = interactor;
        }

        #region ICollectableCommand Implementation

        public bool CanExecute(InteractableManager interactableManager)
        {
            return interactableManager.CanInteractWithInteractables(interactor);
        }

        public void Execute(InteractableManager interactableManager)
        {
            interactableManager.InteractWithInteractables(interactor);
        }

        #endregion
    }
}
