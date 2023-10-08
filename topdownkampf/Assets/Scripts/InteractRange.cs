using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractRange : MonoBehaviour
{
    public GameObject redRune;

    public void pickUpRune()
    {
        Destroy(gameObject);
        redRune.SetActive(true);
    }
}
