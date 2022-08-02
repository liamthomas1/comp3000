using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Totalcube : MonoBehaviour
{
    
    public Text LookatSpeed;
    public int totalcubes;
    public int CUBEANSWERS;
        float  cube;
        GameObject cubeneed, cubehitbox;
    public GameObject Player;
        bool cubeistrue = false;
    Movementmouse movementmouse; //https://www.youtube.com/watch?v=Y7pp2gzCzUI
                                 // Start is called before the first frame update
    private void Awake()
	{
        CUBEANSWERS = Random.Range(1, 12);
        movementmouse = Player.GetComponent<Movementmouse>();
	}
	void Start()
        {
        cube = 0;
        }

        // Update is called once per frame
        void Update()
        {
        cube = movementmouse.speed;
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