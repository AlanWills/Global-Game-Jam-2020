using Celeste.Collectables;
using Celeste.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celeste.Commands.Collectables
{
    public interface IInteractableCommand
    {
        bool CanExecute(InteractableManager interactableManager);
        void Execute(InteractableManager interactableManager);
    }
}
