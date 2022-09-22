using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "test")
        {
            Destroy(gameObject,0.1f);
        }
    }
}
