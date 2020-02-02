using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Celeste.ObjectFX
{
    [AddComponentMenu("Celeste/Object FX/Scene Loader")]
    public class SceneLoader : MonoBehaviour
    {
        #region Serialized Fields

        [SerializeField]
        private string sceneName;

        [SerializeField]
        private LoadSceneMode loadSceneMode = LoadSceneMode.Additive;

        [SerializeField]
        private float delay = 1;

        #endregion

        #region Unity Methods

        public void Start()
        {
            StartCoroutine(LoadScene());
        }

        #endregion

        #region Scene Loading Methods

        public IEnumerator LoadScene()
        {
            if (delay > 0)
            {
                yield return new WaitForSeconds(delay);
            }

            SceneManager.LoadSceneAsync(sceneName, loadSceneMode);
        }

        #endregion
    }
}
