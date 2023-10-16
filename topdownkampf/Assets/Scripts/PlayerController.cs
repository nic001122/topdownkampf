using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] public int health = 10;
    public GameObject attackRangeNorth = default;
    public GameObject attackRangeSouth = default;

    public GameObject attackRangeEast = default;
    public GameObject attackRangeWest = default;

    public MovementScript movementScript;

    public bool isAttacking = false;

    private float timeToAttack = 0.25f;
    [SerializeField] private float timer = 0f;

    public void Start()
    {
        
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            attack();
        }

        if (isAttacking)
        {
            timer += Time.deltaTime;

            if(timer >= timeToAttack)
            {
                isAttacking = false;
                timer = 0;

                attackRangeNorth.SetActive(isAttacking);
                attackRangeSouth.SetActive(isAttacking);

                attackRangeEast.SetActive(isAttacking);
                attackRangeWest.SetActive(isAttacking);
            }
        }
    }

    public void attack()
    {
        // Looking right
        if(movementScript.lookingEast)
        {
            isAttacking = true;
            attackRangeEast.SetActive(isAttacking);
        }

        // Looking left
        if(movementScript.lookingWest)
        {
            isAttacking = true;
            attackRangeWest.SetActive(isAttacking);
        }

        // Looking Up
        if(movementScript.lookingNorth)
        {
            isAttacking = true;
            attackRangeNorth.SetActive(isAttacking);
        }

        // Looking Down
        if(movementScript.lookingSouth)
        {
            isAttacking = true;
            attackRangeSouth.SetActive(isAttacking);
        }
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
