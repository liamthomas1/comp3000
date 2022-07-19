using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Movementmouse : MonoBehaviour
{
    public CharacterController controller; // might need to remove thios for me 
        public float speed = 12f;
    public Text speedtext;
  
    // Update is called once per frame 
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * 12 * Time.deltaTime);
		if (Input.GetKeyDown(KeyCode.W))
		{
            Debug.Log("test");
            SPEEDUP();
		}
        
    }

 void SPEEDUP()
	{
        speedtext.text =   speed.ToString("0.00"); //this is get right infomation
	}
    
}
