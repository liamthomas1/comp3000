using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkifcubecollect : MonoBehaviour
{
	string Test;
	Totalcube totalcube;
	// Start is called before the first frame update
	 void OnTriggerEnter(Collider other)
	{
		//Test =totalcube.CUBEANSWERS.ToString("0.00");
		Debug.Log("check");
		Debug.Log(Test);
	}
	 void Update()
	{
		Test = totalcube.CUBEANSWERS.ToString();
		Debug.Log(Test);
	}
}
