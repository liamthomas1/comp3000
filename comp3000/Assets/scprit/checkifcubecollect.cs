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
	public Text showpointstoplay;
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
		Answerstocube = totalcube.CUBEANSWERS;
		//Test = totalcube.CUBEANSWERS;
		//Debug.Log(Test);
		showpointstoplay.text = Answerstocube.ToString();
	}
 	void score()
	{
		checkspeed = movementmouse.speed;
		if (checkspeed == Answerstocube)
		{
		 totalcube.CUBEANSWERS = Random.Range(1, 12);
			Debug.Log(totalcube.cube);
			pointNumber = totalcube.cube + 1;
			totalcube.cube = pointNumber ;
			Showpoints.text = pointNumber.ToString();
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
