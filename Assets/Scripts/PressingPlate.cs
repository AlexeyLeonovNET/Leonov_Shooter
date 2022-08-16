using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Shooter
{
    public class PressingPlate : MonoBehaviour
    {
        public UnityEvent OnPressed;
        private void OnTriggerEnter(Collider other)
        {
            OnPressed.Invoke();
        }
    }
}