using Celeste.Storage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Celeste.Interactions.Effects
{
    public class ShowCutscene : Effect
    {
        #region Serialized Fields

        [SerializeField]
        private string cutscene;

        #endregion

        public override IEnumerator Do(InteractableManager interactableManager, InventoryManager inventoryManager)
        {
            SceneManager.LoadScene(cutscene, LoadSceneMode.Additive);
            
            return null;
        }
    }
}
