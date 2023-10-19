using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class AttackNorthWest : MonoBehaviour
{
    public EnemyDetermineChildren enemyDetermineChildren;

    [SerializeField] bool playerIsInRange = false;

    [SerializeField] float timeBtwAttack = 0.25f;
    [SerializeField] float btwAttackTimer = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if
        (
            enemyDetermineChildren.isAttackingNorthEast == false &&
            
            enemyDetermineChildren.isAttackingSouthWest == false &&
            enemyDetermineChildren.isAttackingSouthEast == false &&

            enemyDetermineChildren.isAttackingNorth == false &&
            enemyDetermineChildren.isAttackingSouth == false &&

            enemyDetermineChildren.isAttackingWest == false &&
            enemyDetermineChildren.isAttackingEast == false
        )
        
        {
            if(playerIsInRange)
            {
                enemyDetermineChildren.attackRangeNorthWest.SetActive(true);
                enemyDetermineChildren.isAttackingNorthWest = true;
            }

            if(enemyDetermineChildren.isAttackingNorthWest)
            {
                btwAttackTimer += Time.deltaTime;
            }

            if(btwAttackTimer >= timeBtwAttack)
            {
                enemyDetermineChildren.attackRangeNorthWest.SetActive(false);
                enemyDetermineChildren.isAttackingNorthWest = false;

                btwAttackTimer = 0f;
            }
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
