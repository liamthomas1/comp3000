using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Movementmouse : MonoBehaviour
{
    public CharacterController controller; // might need to remove thios for me 
        public float speed = 0f; //overall speed
    public float speedgain = 1f; // speed gain when button hit
    public float speedlost = -1f; // speed lost when button hit
    public float speedmax = 12f;
    public float speedmaxunder = -12f;
    public Text speedtext;
    public Text timer;
    public Text controlslayout;
    public bool changecontrols = false;
    Vector3 Velocity;
    public float gravity = -9f;
   
    // Update is called once per frame 
    void Update()
    {
        Movementunity();

        if (Input.GetKeyDown(KeyCode.Tab)){
            ChangesControlsBool();
		}
        if (changecontrols == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                Debug.Log("test");
                SPEEDUP();
            }
            if (Input.GetKeyDown(KeyCode.F))
            {
                slowdow();
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                returnzero();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("test");
                SPEEDUP();
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                slowdow();
            }
            if (Input.GetKeyDown(KeyCode.V))
            {
                returnzero();
            }
        }
	  
        
    }

 void SPEEDUP()
	{
        if (speed == speedmax)
        {
            timer.text = "you are at max speed";
            speedtext.text = speed.ToString("0.00");
        }
        else
        {
            speed = speed + speedgain;
            speedtext.text = speed.ToString("0.00"); //this is get right infomation
            timer.text = "";
        }
	}
    void slowdow()
	{
        if (speed == speedmaxunder)
        {
           
          timer.text = "you are at max speed";
            
            speedtext.text = speed.ToString("0.00");
        }
        else
        {
            speed = speed + speedlost;
            speedtext.text = speed.ToString("0.00");
            timer.text = "";
        }
	}
    void setupkey()
	{

	}
    void Movementunity()
	{
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        Velocity.y += gravity * Time.deltaTime;
        controller.Move(Velocity * Time.deltaTime);
    }
    void returnzero()
	{
        speed = 0f;
        speedtext.text = speed.ToString("0.00");
        timer.text = "";
	}
    void ChangesControlsBool()
	{
        if (changecontrols == false)
		{
            changecontrols = true;
            controlslayout.text = "R to increase speed\n" + 
				 
				"F to decrease speed\n" +
				"C to Set speed 0\n" +
                "name of this controls is:TWO";


        }
        else if (changecontrols == true)
		{
            changecontrols = false;
            controlslayout.text = "F to increase speed\n" +

               "R to decrease speed\n" +
               "C to Set speed 0\n " +
               "name of this control is:ONE \n"
              ;
        }
	}
 
}

