using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Input
{
    [AddComponentMenu("Celeste/Input/Keyboard 2D Translator")]
    public class Keyboard2DTranslator : MonoBehaviour
    {
        #region Serialized Fields

        [SerializeField]
        private string horizontalAxis = "Horizontal";

        [SerializeField]
        private string verticalAxis = "Vertical";

        [SerializeField]
        private float speed = 1;

        #endregion

        #region Unity Methods

        public void Update()
        {
            float horizontalDelta = UnityEngine.Input.GetAxisRaw(horizontalAxis);
            float verticalDelta = UnityEngine.Input.GetAxisRaw(verticalAxis);

            if (horizontalDelta != 0 || verticalDelta != 0)
            {
                Vector3 delta = new Vector3(horizontalDelta, verticalDelta, 0);
                delta.Normalize();
                transform.Translate(delta * speed * Time.deltaTime);
            }
        }

        #endregion
    }
}
