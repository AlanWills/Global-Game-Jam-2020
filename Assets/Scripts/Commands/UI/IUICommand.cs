using CelesteEngine.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celeste.Commands.UI
{
    public interface IUICommand
    {
        bool CanExecute(UIManager uiManager);
        void Execute(UIManager uiManager);
    }
}
