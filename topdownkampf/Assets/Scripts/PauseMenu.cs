using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject menus = default;
    public GameObject pauseMenu = default;
    public SettingsMenu settingsMenu;
    public bool gameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameIsPaused)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                menus.SetActive(true);
                gameIsPaused = true;
                Time.timeScale = 0f;
            }
        }

        else if(gameIsPaused)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                menus.SetActive(false);
                gameIsPaused = false;
                Time.timeScale = 1f;
            }
        }
    }

    public void ResumeGame()
    {
        menus.SetActive(false);
        gameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void EnterSettings()
    {
        pauseMenu.SetActive(false);
        settingsMenu.settingsMenu.SetActive(true);
    }

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
