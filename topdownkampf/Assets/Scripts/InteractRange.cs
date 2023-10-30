using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractRange : MonoBehaviour
{
    public SFX SFXScript;

    public GameObject redRune;

    public ParticleSystem parSys;

    public void pickUpRune()
    {
        parSys.transform.position = gameObject.transform.position;
        parSys.Play();
        Destroy(gameObject);
        redRune.SetActive(true);
        SFXScript.ItemPickUpSound();
    }
    public void pickUpRune2()
    {
        parSys.transform.position = gameObject.transform.position;
        parSys.Play();
        Destroy(gameObject);
        redRune.SetActive(true);
        SFXScript.ItemPickUpSound();
    }
    public void pickUpRune3()
    {
        parSys.transform.position = gameObject.transform.position;
        parSys.Play();
        Destroy(gameObject);
        redRune.SetActive(true);
        SFXScript.ItemPickUpSound();
    }
    public void pickUpRune4()
    {
        parSys.transform.position = gameObject.transform.position;
        parSys.Play();
        Destroy(gameObject);
        redRune.SetActive(true);
        SFXScript.ItemPickUpSound();
    }
    public void pickUpRune5()
    {
        parSys.transform.position = gameObject.transform.position;
        parSys.Play();
        Destroy(gameObject);
        redRune.SetActive(true);
        SFXScript.ItemPickUpSound();
    }
}
