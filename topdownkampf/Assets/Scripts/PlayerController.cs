using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] public int health = 10;
    public GameObject attackRangeHorizontal = default;

    public GameObject attackRangeVertical = default;

    public MovementScript movementScript;

    public bool isAttacking = false;

    private float timeToAttack = 0.25f;
    private float timer = 0f;

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

            if (timer >= timeToAttack)
            {
                isAttacking = false;
                timer = 0;
                attackRangeHorizontal.SetActive(isAttacking);
                attackRangeVertical.SetActive(isAttacking);
            }
        }
    }

    public void attack()
    {
        if(movementScript.lookingHorizontal)
        {
        isAttacking = true;
        attackRangeHorizontal.SetActive(isAttacking);            
        }

        if(movementScript.lookingVertical)
        {
            isAttacking = true;
            attackRangeVertical.SetActive(isAttacking);
        }
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
