using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonUi : MonoBehaviour
{
    
    //[SerializeField] private string driving = "Prototype1";
    //[SerializeField] private string plane = "Challenge1";

    public void DrivingScene()
    {
        SceneManager.LoadScene("Prototype1");
    }

    public void PlaneScene()
    {
        SceneManager.LoadScene("Challenge1");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
