using Celeste.Commands;
using Celeste.Commands.UI;
using Celeste.Storage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celeste.Interactions.Effects
{
    public class AddProgress : Effect
    {
        public override IEnumerator Do(InteractableManager interactableManager, InventoryManager inventoryManager)
        {
            CommandManager.QueueCommand(new IncrementProgress(0.25f));

            return null;
;        }
    }
}
