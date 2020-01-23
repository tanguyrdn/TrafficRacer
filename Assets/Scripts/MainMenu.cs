using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("UIPath2");

    }

    public void ChooseRoad1()
    {
        SceneManager.LoadScene("Road1");
    }

    public void ChooseRoad2()
    {
        SceneManager.LoadScene("Road2");
    }
}
