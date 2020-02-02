using Celeste.Storage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Celeste.Interactions.Effects
{
    public abstract class Effect : ScriptableObject
    {
        public abstract IEnumerable Do(InteractableManager interactableManager, InventoryManager inventoryManager);
    }
}
