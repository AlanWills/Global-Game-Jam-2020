using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Celeste.GraphicalFX
{
    [AddComponentMenu("Celeste/Graphical FX/Opacity Lerper")]
    public class OpacityLerper : MonoBehaviour
    {
        #region Serialized Fields

        [SerializeField]
        private Image image;

        [SerializeField]
        private float target = 0;

        [SerializeField]
        private float delay = 0;

        [SerializeField]
        private float duration = 1;

        #endregion

        #region Unity Methods

        public void Start()
        {
            StartCoroutine(UpdateOpacity());
        }

        #endregion

        #region Opacity Methods

        private IEnumerator UpdateOpacity()
        {
            if (delay > 0)
            {
                yield return new WaitForSeconds(delay);
            }

            float currentTime = 0;
            float startValue = image.color.a;

            while (currentTime <= duration)
            {
                Color color = image.color;
                color.a = Mathf.Lerp(startValue, target, currentTime / duration);
                image.color = color;
                currentTime += Time.deltaTime;

                yield return null;
            }

            Color finalColor = image.color;
            finalColor.a = target;
            image.color = finalColor;
        }

        #endregion
    }
}
