using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Application
{
    [AddComponentMenu("Celeste/Application/Exit")]
    public class Exit : MonoBehaviour
    {
        public void Quit()
        {
            UnityEngine.Application.Quit();
        }
    }
}
