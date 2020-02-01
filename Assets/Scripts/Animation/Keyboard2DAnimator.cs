using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Animation
{
    [AddComponentMenu("Celeste/Animation/Keyboard 2D Animator")]
    public class Keyboard2DAnimator : MonoBehaviour
    {
        #region Serialized Fields

        [SerializeField]
        private string horizontalAxis = "Horizontal";

        [SerializeField]
        private string verticalAxis = "Vertical";

        [SerializeField]
        private SpriteRenderer spriteRenderer;

        [SerializeField]
        private Sprite faceLeftSprite;

        [SerializeField]
        private Sprite faceRightSprite;

        [SerializeField]
        private Sprite faceUpSprite;

        [SerializeField]
        private Sprite faceDownSprite;

        #endregion

        #region Unity Methods

        public void Update()
        {
            float horizontalDelta = UnityEngine.Input.GetAxisRaw(horizontalAxis);
            float verticalDelta = UnityEngine.Input.GetAxisRaw(verticalAxis);

            if (horizontalDelta != 0)
            {
                if (horizontalDelta > 0 && faceRightSprite != null)
                {
                    spriteRenderer.sprite = faceRightSprite;
                }
                else if (horizontalDelta < 0 && faceLeftSprite != null)
                {
                    spriteRenderer.sprite = faceLeftSprite;
                }
            }
            else if (verticalDelta != 0)
            {
                if (verticalDelta > 0 && faceUpSprite != null)
                {
                    spriteRenderer.sprite = faceUpSprite;
                }
                else if (verticalDelta < 0 && faceDownSprite != null)
                {
                    spriteRenderer.sprite = faceDownSprite;
                }
            }
        }

        #endregion
    }
}
