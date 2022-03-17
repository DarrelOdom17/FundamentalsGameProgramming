using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace FulcrumSystems.Helper
{
    [System.Serializable]
    public class HealthChangedEvent : UnityEvent<HealthChangedObject> { }
    [System.Serializable]
    public class HealedEvent : UnityEvent<int> { }

    public class Health : MonoBehaviour
    {

    }

    public struct HealthChangedObject
    {
        public int maxHealth;
        public int currentHealth;
        public int delta;
    }
}