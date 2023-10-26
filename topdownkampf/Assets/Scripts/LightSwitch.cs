using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;


public class LightSwitch : MonoBehaviour
{
    public SFX SFXScript;

    public GameObject warningText;

    
    public Slider game1, game2, game3;

    public Light2D lantern;
    public bool lightStatus = true;

    public Slider lanternSlider;

    public GameObject MiniGameLantern;

    // Start is called before the first frame update
    void Start()
    {
        warningText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            lightStatus = !lightStatus;
            SFXScript.LightSwitchSound();
            
        }
        if (lanternSlider.value == 0)
        {
            warningText.SetActive(true);

            if (Input.GetKeyDown(KeyCode.C))
            {
                MiniGameLantern.SetActive(true);
            }
            
        }
        if (MiniGameLantern == true && game1.value == 1 && game2.value == 1 && game3.value == 1)
        {
            MiniGameLantern.SetActive(false);
            lanternSlider.value = 25;
            warningText.SetActive(false);
        }

        switch (lightStatus)
        {
            case true:
                lantern.intensity = 0; break;
            default:
                lantern.intensity = 1; break;
        }
    }
}
