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
        private string horizontalAxis;

        [SerializeField]
        private string verticalAxis;

        [SerializeField]
        private float speed = 1;

        #endregion

        #region Unity Methods

        public void Update()
        {
            float horizontalDelta = UnityEngine.Input.GetAxis(horizontalAxis);
            float verticalDelta = UnityEngine.Input.GetAxis(verticalAxis);

            if (horizontalDelta > 0 || verticalDelta > 0)
            {
                transform.Translate(horizontalDelta * speed, verticalDelta * speed, 0);
            }
        }

        #endregion
    }
}
