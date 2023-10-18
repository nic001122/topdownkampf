using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class AttackNorthWest : MonoBehaviour
{
    public EnemyDetermineChildren enemyDetermineChildren;

    [SerializeField] bool playerIsInRange = false;
    [SerializeField] bool isAttacking = false;

    [SerializeField] float timeBtwAttack = 0.25f;
    [SerializeField] float btwAttackTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(playerIsInRange)
        {
            enemyDetermineChildren.attackRangeNorthWest.SetActive(true);
            isAttacking = true;
        }

        if(isAttacking)
        {
            btwAttackTimer += Time.deltaTime;
        }

        if(btwAttackTimer >= timeBtwAttack)
        {
            enemyDetermineChildren.attackRangeNorthWest.SetActive(false);
            isAttacking = false;

            btwAttackTimer = 0f;
            Debug.Log("Attacked");
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerIsInRange = true;
        }
    }

    void OnTriggerExit2D()
    {
        playerIsInRange = false;
    }
}
