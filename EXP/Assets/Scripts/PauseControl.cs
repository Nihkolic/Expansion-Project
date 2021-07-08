using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseControl : MonoBehaviour
{
    public static bool gameIsPaused;

    [Header("Keybinds")]
    [SerializeField] KeyCode pauseKey = KeyCode.Escape;

    [Header("References")]
    [SerializeField] GameObject goPauseMenu;
    public AudioSource audioSource;
    public AudioClip clicClip;

    private void Start()
    {
        goPauseMenu.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(pauseKey))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
    }
    void PauseGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
            goPauseMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            ResumeGame();
        }
    }
    public void ResumeGame() 
    {
        Time.timeScale = 1;
        gameIsPaused = false;
        goPauseMenu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        PlayClic();
    }
    public void ToMainMenu()
    {
        Time.timeScale = 1;
        gameIsPaused = false;
        SceneManager.LoadScene(0); 
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        PlayClic();
    }
    public void QuitGame()
    {
        Application.Quit();
        PlayClic();
    }
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        PlayClic();
    }
    public void PlayClic()
    {
        audioSource.PlayOneShot(clicClip, 0.8f);
    }
}
