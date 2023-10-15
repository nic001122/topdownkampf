using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    [SerializeField] public int health = 10;
    public GameObject attackRange = default;

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
                attackRange.SetActive(isAttacking);
            }
        }
    }

    public void attack()
    {
        isAttacking = true;
        attackRange.SetActive(isAttacking);
    }
    
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
