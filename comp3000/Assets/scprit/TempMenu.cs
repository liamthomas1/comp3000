using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class TempMenu : MonoBehaviour
{
    public GameObject MENU;
    public bool MENUon = false;
 

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
		{
            //exitgame();
            GAMETIME();
		}
    }
    void GAMETIME()
	{
        if (MENUon == true)
        {
            MENUon = false;
            Time.timeScale = 1;
            MENU.SetActive(MENUon);
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if(MENUon == false){
            MENUon = true;
            Time.timeScale = 0;
            MENU.SetActive(MENUon);
            Cursor.lockState = CursorLockMode.Confined;
		}
	}
   public void exitgame()
	{
        Application.Quit();
	}
    public void startgame()
	{
        SceneManager.LoadScene(1);
	}
   public void Exittomenu()
	{
        SceneManager.LoadScene(0);
	}
}
