using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.GraphicalFX
{
    [AddComponentMenu("Celeste/Graphical FX/Keyboard Visibility")]
    public class KeyboardVisibility : MonoBehaviour
    {
        #region Serialized Fields

        [SerializeField]
        private string horizontalAxis = "Horizontal";

        [SerializeField]
        private string verticalAxis = "Vertical";

        [SerializeField]
        private SpriteRenderer spriteRenderer;

        #endregion

        #region Unity Methods

        public void Start()
        {
            spriteRenderer.enabled = false;
        }

        public void Update()
        {
            float horizontalDelta = UnityEngine.Input.GetAxisRaw(horizontalAxis);
            float verticalDelta = UnityEngine.Input.GetAxisRaw(verticalAxis);

            spriteRenderer.enabled = horizontalDelta != 0 || verticalDelta != 0;
        }

        #endregion
    }
}
