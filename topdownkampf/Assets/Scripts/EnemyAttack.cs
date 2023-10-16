using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAttack : MonoBehaviour
{
    bool playerIsTouchingNorthEast = false;
    bool playerIsTouchingNorthWest = false;
    bool playerIsTouchingSouthEast = false;
    bool playerIsTouchingSouthWest = false;

    bool playerIsTouchingNorth = false;
    bool playerIsTouchingSouth = false;
    bool playerIsTouchingWest = false;
    bool playerIsTouchingEast = false;

    // Attack
    bool isAttacking = false;
    float timer = 0f;
    float finishAttack;

    public GameObject attackRangeNorth = default;
    public GameObject attackRangeSouth = default;

    public GameObject attackRangeEast = default;
    public GameObject attackRangeWest = default;

    public GameObject attackRangeNorthEast = default;
    public GameObject attackRangeNorthWest = default;

    public GameObject attackRangeSouthEast = default;
    public GameObject attackRangeSouthWest = default;

    void Start()
    {
        attackRangeNorthWest = transform.GetChild(1).gameObject;
        attackRangeNorthEast = transform.GetChild(2).gameObject;
        attackRangeSouthWest = transform.GetChild(3).gameObject;
        attackRangeSouthEast = transform.GetChild(4).gameObject;
        attackRangeNorth = transform.GetChild(5).gameObject;
        attackRangeSouth = transform.GetChild(6).gameObject;
        attackRangeWest = transform.GetChild(7).gameObject;
        attackRangeEast = transform.GetChild(8).gameObject;
    }
    // Update is called once per frame
    void Update()
    {   
        if(isAttacking)
        {
            timer += Time.deltaTime;
        }

        if(timer >= finishAttack)
        {
            timer = 0f;
            isAttacking = false;
        }
        attack();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy Scan NorthWest"))
        {
            playerIsTouchingNorthWest = true;
        }

        if(collision.CompareTag("Enemy Scan NorthEast"))
        {
            playerIsTouchingNorthEast = true;
        }

        if(collision.CompareTag("Enemy Scan SouthWest"))
        {
            playerIsTouchingSouthWest = true;
        }

        if(collision.CompareTag("Enemy Scan SouthEast"))
        {
            playerIsTouchingSouthEast = true;
        }

        if(collision.CompareTag("Enemy Scan North"))
        {
            playerIsTouchingNorth = true;
        }

        if(collision.CompareTag("Enemy Scan South"))
        {
            playerIsTouchingSouth = true;
        }

        if(collision.CompareTag("Enemy Scan West"))
        {
            playerIsTouchingWest = true;
        }

        if(collision.CompareTag("Enemy Scan East"))
        {
            playerIsTouchingEast = true;
        }    
    }
        
    void attack()
    {
        // Touching Top Right
        if(playerIsTouchingNorthEast && !isAttacking)
        {
            isAttacking = true;
            attackRangeNorthEast.SetActive(isAttacking);
        }

        // Touching Top Left
        if(playerIsTouchingNorthWest && !isAttacking)
        {
            isAttacking = true;
            attackRangeNorthWest.SetActive(isAttacking);
        }

        // Touching Bottom Right
        if(playerIsTouchingSouthEast && !isAttacking)
        {
            isAttacking = true;
            attackRangeSouthEast.SetActive(isAttacking);
        }

        //Touching Bottom Left
        if(playerIsTouchingSouthWest && !isAttacking)
        {
            isAttacking = true;
            attackRangeSouthWest.SetActive(isAttacking);
        }

        // Touching Right
        if(playerIsTouchingEast && !isAttacking)
        {
            isAttacking = true;
            attackRangeEast.SetActive(isAttacking);
        }

        // Touching Left
        if(playerIsTouchingWest && !isAttacking)
        {
            isAttacking = true;
            attackRangeWest.SetActive(isAttacking);
        }

        // Touching Top
        if(playerIsTouchingNorth && !isAttacking)
        {
            isAttacking = true;
            attackRangeNorth.SetActive(isAttacking);
        }

        // Touching Bottom
        if(playerIsTouchingSouth && !isAttacking)
        {
            isAttacking = true;
            attackRangeSouth.SetActive(isAttacking);
        }
    }
}
