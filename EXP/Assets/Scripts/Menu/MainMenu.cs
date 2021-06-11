using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject main, credits;

    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void Credits()
    {
        main.SetActive(false);
        credits.SetActive(true);
    }
    public void Back()
    {
        main.SetActive(true);
        credits.SetActive(false);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
