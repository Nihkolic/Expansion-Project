using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject main, credits;
    AudioSource compAudioSource;
    //public AudioClip acceptSFX;
    private void Awake()
    {
        compAudioSource = GetComponent<AudioSource>();
    }

    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void Credits()
    {
        main.SetActive(false);
        credits.SetActive(true);
        //compAudioSource.PlayOneShot(acceptSFX);
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
