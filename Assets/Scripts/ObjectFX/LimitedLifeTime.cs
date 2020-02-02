using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.ObjectFX
{
    [AddComponentMenu("Celeste/Object FX/Limited Life Time")]
    public class LimitedLifeTime : MonoBehaviour
    {
        #region Serialized Fields

        [SerializeField]
        private float delay = 1;

        #endregion

        #region Unity Methods

        public void Start()
        {
            StartCoroutine(StartLifeCounter());
        }

        #endregion

        #region Life Time Methods

        public IEnumerator StartLifeCounter()
        {
            if (delay > 0)
            {
                yield return new WaitForSeconds(delay);
            }

            GameObject.Destroy(gameObject);
        }

        #endregion
    }
}
