using Celeste.Commands;
using Celeste.Commands.Collectables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Collectables
{
    [RequireComponent(typeof(Collider2D))]
    public class Collector : MonoBehaviour
    {
        #region Serialized Fields

        [SerializeField]
        private KeyCode collectionKey;

        #endregion

        #region Unity Methods

        public void Update()
        {
            if (UnityEngine.Input.GetKeyDown(collectionKey))
            {
                Debug.Log("TryCollectItems");
                CommandManager.QueueCommand(new TryCollectCollectables(this));
            }
        }

        #endregion
    }
}
