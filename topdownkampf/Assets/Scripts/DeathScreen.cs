using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour
{
    public SFX SFXScript;

    public GameObject deathScreen;
    public Health health;

    // Update is called once per frame
    void Update()
    {
        if(health.currentHealth <= 0)
        {
            SFXScript.PlayerDeathSound();
            deathScreen.SetActive(true);
            gameObject.SetActive(false);
            
        }
    }

    public void Respawn()
    {
        SceneManager.LoadScene("Level 1");
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
