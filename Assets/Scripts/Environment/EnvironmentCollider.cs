using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Environment
{
    [AddComponentMenu("Celeste/Environment/Environment Collider")]
    [RequireComponent(typeof(Collider2D))]
    public class EnvironmentCollider : MonoBehaviour
    {
        #region Properties and Fields

        public const string EnvironmentTag = "Environment";

        #endregion

        #region Collision Callbacks

        public void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag(EnvironmentTag))
            {
                // Disable movement
            }
        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            
        }

        #endregion
    }
}
