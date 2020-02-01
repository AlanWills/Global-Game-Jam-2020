using Celeste.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celeste.Commands.Storage
{
    public interface IInventoryCommand
    {
        bool CanExecute(InventoryManager inventoryManager);
        void Execute(InventoryManager inventoryManager);
    }
}
