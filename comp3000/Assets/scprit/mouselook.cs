using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouselook : MonoBehaviour
{
    //using this https://www.youtube.com/watch?v=4HpC--2iowE&t=875s to get base line of third person camre as i want the user to be controls of it using keys
    public float mouseSensitivity = 100f;
    public Transform playerBody;
    float xRoatation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;
        xRoatation -= mouseY;
        xRoatation = Mathf.Clamp(xRoatation, 1f, -1f); // fix the problem with this code by doing this 
      
        transform.localRotation = Quaternion.Euler(xRoatation, 0f, 0f);
       playerBody.Rotate(Vector3.up * mouseX);

    }
}
