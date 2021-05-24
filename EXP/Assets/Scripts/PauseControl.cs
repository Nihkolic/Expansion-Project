using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControl : MonoBehaviour
{
    public static bool gameIsPaused;

    [Header("Keybinds")]
    [SerializeField] KeyCode pauseKey = KeyCode.Escape;

    [Header("References")]
    [SerializeField] GameObject goPauseMenu;

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
    }
    public void ToMainMenu()
    {
        Time.timeScale = 1;
        gameIsPaused = false;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
