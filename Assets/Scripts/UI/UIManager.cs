using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace CelesteEngine.UI
{
    [AddComponentMenu("Celeste/UI/UIManager")]
    public class UIManager : MonoBehaviour
    {
        #region Serialized

        [SerializeField]
        private Image progressBarForeground;

        #endregion

        #region Progress Bar Methods

        public void IncrementProgressBarFill(float fillIncrement)
        {
            progressBarForeground.fillAmount += fillIncrement;
        }

        #endregion
    }
}
