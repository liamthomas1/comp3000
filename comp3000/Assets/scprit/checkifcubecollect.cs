using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class checkifcubecollect : MonoBehaviour
{
	public static int numberofcubetodo = 5;
	int count =0;
	int Answerstocube;
	Totalcube totalcube;
	Movementmouse movementmouse;
	public GameObject playscore;
	public GameObject OBJECTSTOREMOVE;
	public GameObject OBJECTSTOADD;
	public GameObject Collidercube;
	public Text Showpoints;
	string points;
	public float pointNumber;
	float checkspeed;
	// Start is called before the first frame update
	private void Awake()
	{
		totalcube = playscore.GetComponent<Totalcube>();
		movementmouse = playscore.GetComponent<Movementmouse>();
		Answerstocube = totalcube.CUBEANSWERS;

	}
	void OnTriggerEnter(Collider other)
	{
		Answerstocube = totalcube.CUBEANSWERS;

		Debug.Log(Answerstocube);
		score();
		

	}
	 void Update()
	{
		//Test = totalcube.CUBEANSWERS;
		//Debug.Log(Test);
	}
 	void score()
	{
		checkspeed = movementmouse.speed;
		if (checkspeed == Answerstocube)
		{
			pointNumber = totalcube.cube + 1;
			
			Debug.Log("it work");
			Debug.Log(pointNumber);
			Destroy(OBJECTSTOADD.GetComponent<BoxCollider>());
			Destroy(OBJECTSTOREMOVE); 
		}
		else if (checkspeed < Answerstocube || checkspeed > Answerstocube) {
			Showpoints.text = "you have the wrong speed";
			Debug.Log("it works for wrong answers");
		}
	}
}
