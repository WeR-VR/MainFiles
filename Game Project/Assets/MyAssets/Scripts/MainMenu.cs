using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void Play()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Play");
    }
    public void HowToPlay()
    {
        Debug.Log("HowToPlay");
    }
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
