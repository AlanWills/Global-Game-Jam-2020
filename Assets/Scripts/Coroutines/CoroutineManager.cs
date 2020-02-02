using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Coroutines
{
    [AddComponentMenu("Celeste/Coroutines/Coroutine Manager")]
    public class CoroutineManager : MonoBehaviour
    {
        #region Properties and Fields

        private static CoroutineManager instance;

        #endregion

        #region Unity Methods

        public void Start()
        {
            instance = GetComponent<CoroutineManager>();
        }

        #endregion

        #region Coroutine Methods

        public static void PerformCoroutine(IEnumerator coroutine)
        {
            instance.StartCoroutine(coroutine);
        }

        #endregion
    }
}
