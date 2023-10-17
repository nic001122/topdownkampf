using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    [SerializeField] Slider healthBar;

    public float maxHealth = 10;
    public float currentHealth;


    public bool enemyIsAttackingNorth;
    public bool enemyIsAttackingNorthEast;
    public bool enemyIsAttackingNorthWest;

    public bool enemyIsAttackingSouth;
    public bool enemyIsAttackingSouthEast;
    public bool enemyIsAttackingSouthWest;

    public bool enemyIsAttackingEast;
    public bool enemyIsAttackingWest;

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

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy Attack Range NorthWest"))
        {
            enemyIsAttackingEast = false;
            enemyIsAttackingNorth = false;
            enemyIsAttackingNorthEast = false;
            enemyIsAttackingSouth = false;
            enemyIsAttackingSouthEast = false;
            enemyIsAttackingSouthWest = false;
            enemyIsAttackingWest = false;

            enemyIsAttackingNorthWest = true;

            currentHealth -= 2;
        }

        if(collision.CompareTag("Enemy Attack Range NorthEast"))
        {
            enemyIsAttackingEast = false;
            enemyIsAttackingNorth = false;
            enemyIsAttackingNorthWest = false;
            enemyIsAttackingSouth = false;
            enemyIsAttackingSouthEast = false;
            enemyIsAttackingSouthWest = false;
            enemyIsAttackingWest = false;

            enemyIsAttackingNorthEast = true;

            currentHealth -= 2;
        }

        if(collision.CompareTag("Enemy Attack Range SouthWest"))
        {
            enemyIsAttackingEast = false;
            enemyIsAttackingNorth = false;
            enemyIsAttackingNorthEast = false;
            enemyIsAttackingNorthWest = false;
            enemyIsAttackingSouth = false;
            enemyIsAttackingSouthEast = false;
            enemyIsAttackingWest = false;

            enemyIsAttackingSouthWest = true;

            currentHealth -= 2;
        }

        if(collision.CompareTag("Enemy Attack Range SouthEast"))
        {
            enemyIsAttackingEast = false;
            enemyIsAttackingNorth = false;
            enemyIsAttackingNorthEast = false;
            enemyIsAttackingNorthWest = false;
            enemyIsAttackingSouth = false;
            enemyIsAttackingSouthWest = false;
            enemyIsAttackingWest = false;

            enemyIsAttackingSouthEast = true;

            currentHealth -= 2;
        }

        if(collision.CompareTag("Enemy Attack Range North"))
        {
            enemyIsAttackingEast = false;
            enemyIsAttackingNorthEast = false;
            enemyIsAttackingNorthWest = false;
            enemyIsAttackingSouth = false;
            enemyIsAttackingSouthEast = false;
            enemyIsAttackingSouthWest = false;
            enemyIsAttackingWest = false;

            enemyIsAttackingNorth = true;

            currentHealth -= 2;
        }

        if(collision.CompareTag("Enemy Attack Range South"))
        {
            enemyIsAttackingEast = false;
            enemyIsAttackingNorth = false;
            enemyIsAttackingNorthEast = false;
            enemyIsAttackingNorthWest = false;
            enemyIsAttackingSouthEast = false;
            enemyIsAttackingSouthWest = false;
            enemyIsAttackingWest = false;

            enemyIsAttackingSouth = true;

            currentHealth -= 2;
        }

        if(collision.CompareTag("Enemy Attack Range West"))
        {
            enemyIsAttackingEast = false;
            enemyIsAttackingNorth = false;
            enemyIsAttackingNorthEast = false;
            enemyIsAttackingNorthWest = false;
            enemyIsAttackingSouth = false;
            enemyIsAttackingSouthEast = false;
            enemyIsAttackingSouthWest = false;

            enemyIsAttackingWest = true;

            currentHealth -= 2;
        }

        if(collision.CompareTag("Enemy Attack Range East"))
        {
            enemyIsAttackingNorth = false;
            enemyIsAttackingNorthEast = false;
            enemyIsAttackingNorthWest = false;
            enemyIsAttackingSouth = false;
            enemyIsAttackingSouthEast = false;
            enemyIsAttackingSouthWest = false;
            enemyIsAttackingWest = false;

            enemyIsAttackingEast = true;

            currentHealth -= 2;
        }
    }
}
