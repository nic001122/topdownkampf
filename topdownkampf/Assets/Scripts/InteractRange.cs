using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractRange : MonoBehaviour
{
    public SFX SFXScript;

    public GameObject redRune;

    public void pickUpRune()
    {
        Destroy(gameObject);
        redRune.SetActive(true);
        SFXScript.ItemPickUpSound();
    }
    public void pickUpRune2()
    {
        Destroy(gameObject);
        redRune.SetActive(true);
        SFXScript.ItemPickUpSound();
    }
    public void pickUpRune3()
    {
        Destroy(gameObject);
        redRune.SetActive(true);
        SFXScript.ItemPickUpSound();
    }
    public void pickUpRune4()
    {
        Destroy(gameObject);
        redRune.SetActive(true);
        SFXScript.ItemPickUpSound();
    }
    public void pickUpRune5()
    {
        Destroy(gameObject);
        redRune.SetActive(true);
        SFXScript.ItemPickUpSound();
    }
}
