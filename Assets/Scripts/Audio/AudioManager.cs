using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Audio
{
    [AddComponentMenu("Celeste/Audio/Audio Manager")]
    public class AudioManager : MonoBehaviour
    {
        #region Properties and Fields

        [SerializeField]
        private AudioSource interactionBeep;

        private static AudioManager instance;

        #endregion

        #region Unity Methods

        public void Awake()
        {
            instance = GetComponent<AudioManager>();
            Object.DontDestroyOnLoad(instance.gameObject);
        }

        #endregion

        public static void PlayBeep()
        {
            instance.interactionBeep.Play();
        }
    }
}
