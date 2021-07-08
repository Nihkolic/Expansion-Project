using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControlador : MonoBehaviour
{
    public MenuModelo modelo;
    public AudioSource audioSource;
    public AudioClip clicClip;

    private void Awake()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        if (0 == SceneManager.GetActiveScene().buildIndex)
        {
            modelo.credits.SetActive(false);
        }
    }
    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
        PlayClic();
    }
    public void Credits()
    {
        modelo.main.SetActive(false);
        modelo.credits.SetActive(true);
        PlayClic();
    }
    public void Back()
    {
        modelo.main.SetActive(true);
        modelo.credits.SetActive(false);
        PlayClic();
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
        PlayClic();
    }
    public void PlayClic()
    {
        audioSource.PlayOneShot(clicClip, 0.8f);
    }
}
