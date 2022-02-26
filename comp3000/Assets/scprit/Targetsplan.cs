using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Targetsplan : MonoBehaviour
{
    int test;
    public Text scoretext;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
		{
            scoretext.text = "";
            test = test + 1;
            scoretext.text = test.ToString("0");
		}

    }
}
