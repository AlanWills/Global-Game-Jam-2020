using Celeste.Collectables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celeste.Commands.Collectables
{
    public interface ICollectableCommand
    {
        bool CanExecute(CollectableManager collectableManager);
        void Execute(CollectableManager collectableManager);
    }
}
