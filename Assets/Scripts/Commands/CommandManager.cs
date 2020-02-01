using Celeste.Collectables;
using Celeste.Commands.Collectables;
using Celeste.Commands.Storage;
using Celeste.Commands.UI;
using Celeste.Storage;
using CelesteEngine.UI;
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

        private List<IInventoryCommand> queuedInventoryCommands = new List<IInventoryCommand>();
        private List<IInventoryCommand> inventoryCommands = new List<IInventoryCommand>();

        private List<IUICommand> queuedUICommands = new List<IUICommand>();
        private List<IUICommand> uiCommands = new List<IUICommand>();

        #endregion

        #region Serialized Fields

        [SerializeField]
        private CollectableManager collectableManager;

        [SerializeField]
        private InventoryManager inventoryManager;

        [SerializeField]
        private UIManager uiManager;

        #endregion

        #region Unity Methods

        public void Start()
        {
            instance = GetComponent<CommandManager>();
        }

        public void Update()
        {
            UpdateCollectableCommands();
            UpdateInventoryCommands();
            UpdateUICommands();
        }

        #endregion

        #region Generic Command Methods

        private static void QueueCommand<T>(T command, List<T> queuedCommands)
        {
            queuedCommands.Add(command);
        }

        #endregion

        #region Collectable Command Methods

        public static void QueueCommand(ICollectableCommand collectableCommand)
        {
            QueueCommand(collectableCommand, instance.queuedCollectableCommands);
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

        #region Inventory Command Methods

        public static void QueueCommand(IInventoryCommand inventoryCommand)
        {
            QueueCommand(inventoryCommand, instance.queuedInventoryCommands);
        }

        private void UpdateInventoryCommands()
        {
            inventoryCommands.AddRange(queuedInventoryCommands);
            queuedInventoryCommands.Clear();

            foreach (IInventoryCommand command in inventoryCommands)
            {
                if (command.CanExecute(inventoryManager))
                {
                    command.Execute(inventoryManager);
                }
            }

            inventoryCommands.Clear();
        }

        #endregion

        #region UI Command Methods

        public static void QueueCommand(IUICommand uiCommand)
        {
            QueueCommand(uiCommand, instance.queuedUICommands);
        }

        private void UpdateUICommands()
        {
            uiCommands.AddRange(queuedUICommands);
            queuedUICommands.Clear();

            foreach (IUICommand command in uiCommands)
            {
                if (command.CanExecute(uiManager))
                {
                    command.Execute(uiManager);
                }
            }

            uiCommands.Clear();
        }

        #endregion
    }
}
