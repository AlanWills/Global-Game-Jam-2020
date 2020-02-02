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
    [AddComponentMenu("Celeste/Object FX/Scene Unloader")]
    public class SceneUnloader : MonoBehaviour
    {
        #region Serialized Fields

        [SerializeField]
        private string sceneName = "";

        [SerializeField]
        private float delay = 1;

        #endregion

        #region Unity Methods

        public void Start()
        {
            StartCoroutine(UnloadScene());
        }

        #endregion

        #region Scene Unloading Methods

        public IEnumerator UnloadScene()
        {
            if (delay > 0)
            {
                yield return new WaitForSeconds(delay);
            }

            SceneManager.UnloadSceneAsync(string.IsNullOrEmpty(sceneName) ? gameObject.scene.name : sceneName);
        }

        #endregion
    }
}
