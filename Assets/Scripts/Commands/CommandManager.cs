using Celeste.Collectables;
using Celeste.Commands.Collectables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Commands
{
    [AddComponentMenu("Celeste/Commands/Command Manager")]
    public class CommandManager : MonoBehaviour
    {
        #region Properties and Fields

        private static CommandManager instance;

        private List<ICollectableCommand> queuedCollectableCommands = new List<ICollectableCommand>();
        private List<ICollectableCommand> collectableCommands = new List<ICollectableCommand>();

        #endregion

        #region Serialized Fields

        [SerializeField]
        private CollectableManager collectableManager;

        #endregion

        #region Unity Methods

        public void Awake()
        {
            instance = GetComponent<CommandManager>();
        }

        public void Update()
        {
            UpdateCollectableCommands();
        }

        #endregion

        #region Command Methods

        public static void QueueCommand(ICollectableCommand collectableCommand)
        {
            instance.queuedCollectableCommands.Add(collectableCommand);
        }

        private void UpdateCollectableCommands()
        {
            collectableCommands.AddRange(queuedCollectableCommands);
            queuedCollectableCommands.Clear();

            foreach (ICollectableCommand command in collectableCommands)
            {
                if (command.CanExecute(collectableManager))
                {
                    command.Execute(collectableManager);
                }
            }

            collectableCommands.Clear();
        }

        #endregion
    }
}
