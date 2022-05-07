using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public int move;

    public void Loadlevelusertest()
	{
    
            SceneManager.LoadScene(1);
     

	}
    public void LoadMainmenu()
    {

        SceneManager.LoadScene(0);


    }
    public void levelquit() {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
