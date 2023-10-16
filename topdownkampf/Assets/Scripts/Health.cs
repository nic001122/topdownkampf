using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] Slider healthBar;

    public float maxHealth = 10;
    public float currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = currentHealth;


        if (Input.GetKeyDown(KeyCode.E))
        {
            currentHealth = currentHealth - 2;
        }
        if (currentHealth <= 0)
        {
            
            Destroy(gameObject, 0.1f);
        }

    }
    public void kp()
    {
        
    }
}
