using Celeste.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Interactions.Requirements
{
    public abstract class Requirement : ScriptableObject
    {
        public abstract bool IsMet(InventoryManager inventoryManager);
    }
}
