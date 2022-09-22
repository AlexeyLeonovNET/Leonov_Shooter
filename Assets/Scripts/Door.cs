using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool isOpen;
    
    public void Open()
    {
        isOpen = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isOpen)
        {
            Transform cube = transform.GetChild(0);
            cube.localPosition = Vector3.MoveTowards(cube.localPosition, Vector3.up * 2,Time.deltaTime);
        }
    }
}
