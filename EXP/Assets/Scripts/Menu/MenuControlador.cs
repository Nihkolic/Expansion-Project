using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControlador : MonoBehaviour
{
    public MenuModelo modelo;

    private void Awake()
    {
        //modelo.compAudioSource = GetComponent<AudioSource>();
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

    }
    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
    public void Credits()
    {
        modelo.main.SetActive(false);
        modelo.credits.SetActive(true);
        //compAudioSource.PlayOneShot(acceptSFX);
       
    }
    public void Back()
    {
        modelo.main.SetActive(true);
        modelo.credits.SetActive(false);
        
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
