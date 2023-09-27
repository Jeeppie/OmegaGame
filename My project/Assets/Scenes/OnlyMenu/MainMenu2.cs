using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu2 : MonoBehaviour

{
    public GameObject SettingsMenu;
  

  public void StartGame ()
    {
        SceneManager.LoadScene(1);
    }

    public void SettingsButton ()
    {
        SettingsMenu.SetActive(true);
        
    }

    public void ReturnSettingsButton () 
    {
        SettingsMenu.SetActive(false);
        
    }

    public void RecordsButton ()
    {

    }

    public void ExitGame ()
    {
        Debug.Log("Quitting");
        Application.Quit ();
    }
}
