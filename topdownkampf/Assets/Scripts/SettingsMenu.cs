using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public GameObject settingsMenu = default;
    public PauseMenu pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResumeGame()
    {
        settingsMenu.SetActive(false);
        pauseMenu.pauseMenu.SetActive(true);
        pauseMenu.menus.SetActive(false);
        pauseMenu.gameIsPaused = false;
        Time.timeScale = 1f;
    }

    public void BackToPauseScreen()
    {
        settingsMenu.SetActive(false);
        pauseMenu.pauseMenu.SetActive(true);
    }
}
