using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopTrigger : MonoBehaviour
{
    public SFX SFXScript;

    public bool inGoodRange = false;

    public GameObject ShopPanel;
    public GameObject ShopButtons;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inGoodRange == true)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                ShopPanel.SetActive(true);
                ShopButtons.SetActive(true);
                SFXScript.ShopSound();

            }
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inGoodRange = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            inGoodRange = false;
        }
    }
}
