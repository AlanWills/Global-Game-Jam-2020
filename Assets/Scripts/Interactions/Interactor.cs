using Celeste.Commands;
using Celeste.Commands.Interactables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Interactions
{
    [AddComponentMenu("Celeste/Interactions/Interactor")]
    public class Interactor : MonoBehaviour
    {
        #region Serialized Fields

        [SerializeField]
        private KeyCode interactKey;

        #endregion

        #region Unity Methods

        public void Update()
        {
            if (UnityEngine.Input.GetKeyDown(interactKey))
            {
                CommandManager.QueueCommand(new TryInteractWithInteractables(this));
            }
        }

        #endregion
    }
}
