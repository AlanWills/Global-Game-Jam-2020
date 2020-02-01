using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Viewport
{
    [AddComponentMenu("Celeste/Viewport/Follow Game Object")]
    public class FollowGameObject : MonoBehaviour
    {
        #region Serialized Fields

        [SerializeField]
        private GameObject target;

        #endregion

        #region Unity Methods

        public void Update()
        {
            Vector3 targetPosition = target.transform.position;
            transform.position = new Vector3(targetPosition.x, targetPosition.y, transform.position.z);
        }

        #endregion
    }
}
