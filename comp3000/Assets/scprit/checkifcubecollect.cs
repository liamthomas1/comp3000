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
	public Text Showpoints;
	string points;
	float pointNumber;
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
			pointNumber = pointNumber + 1;
			points = pointNumber.ToString();
			Showpoints.text = "you have this this amount of ponts" + points;
			Debug.Log("it work");
			Debug.Log(pointNumber);
		}
		else if (checkspeed < Answerstocube || checkspeed > Answerstocube) {
			Showpoints.text = "you have the wrong speed";
			Debug.Log("it works for wrong answers");
		}
	}
}
