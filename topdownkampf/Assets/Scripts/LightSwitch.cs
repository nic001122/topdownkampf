using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightSwitch : MonoBehaviour
{
    public Light2D lantern;
    bool lightStatus = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            lightStatus = !lightStatus;
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
