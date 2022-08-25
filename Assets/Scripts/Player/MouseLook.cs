using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public Transform playerBody;
    public float mouseSensilivity = 100f;
    public float xRotation = 0f;
    // Start is called before the first frame update
     public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; 
    }

    // Update is called once per frame
     public void Update()
    {
       float mouseX = Input.GetAxis("Mouse X") * mouseSensilivity * Time.deltaTime;
       float mouseY = Input.GetAxis("Mouse Y") * mouseSensilivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
