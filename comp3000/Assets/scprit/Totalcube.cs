using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Totalcube : MonoBehaviour
{
    
    public Text LookatSpeed;
    public Text scoretrack;
    public int totalcubes;
    public int CUBEANSWERS;
    public string Pointtextscore = "you have THiS amount of  points";
    public string Pointtotal = "out of 5";
       public float  cube;
        GameObject cubeneed, cubehitbox;
    public GameObject Player;
    public GameObject cuber;
        bool cubeistrue = false;
    Movementmouse movementmouse; //https://www.youtube.com/watch?v=Y7pp2gzCzUI
                                 // Start is called before the first frame update
    checkifcubecollect CUBEHERE;
    private void Awake()
	{
        CUBEHERE = cuber.GetComponent<checkifcubecollect>();

        CUBEANSWERS = Random.Range(1, 12);
        movementmouse = Player.GetComponent<Movementmouse>(); // this is reduce from old idea leave this here just so if this does link to somthing it does not melt the code 
	}
	void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
       
        
            
       
            scoretrack.text = Pointtextscore + cube.ToString("0") + Pointtotal;
        
        //Debug.Log(cube);
       
            LookatSpeed.text = CUBEANSWERS.ToString("0.00");
            //Debug.Log(CUBEANSWERS);
        RandomNUMBERHERE();
       
    }

        void cubecollect()
        {
            if (cubeistrue == true)
            {

            }
        }
        void cubehitboxcheck()
        {

        }
    void RandomNUMBERHERE()
	{
        if (Input.GetKeyDown(KeyCode.G)){
            CUBEANSWERS = Random.Range(1, 12);
            Debug.Log(CUBEANSWERS);
        }
        else { };

    }
    }